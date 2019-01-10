//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SnapMD.VirtualCare.Sdk.Interfaces;

namespace SnapMD.VirtualCare.Sdk
{
    //replace all calls and references to webclient, with WebClientWrapper, 
    //and route them through the wrapper.
    /// <summary>
    /// ApiCall information.
    /// </summary>
    public class ApiCall
    {
        private readonly string _apiKey;
        private readonly Uri _baseUri;
        private readonly string _bearerToken;
        private readonly string _developerId;

        /// <summary>
        /// ApiCall Constructor.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUrl"></param>
        /// <param name="bearerToken"></param>
        /// <param name="client"></param>
        /// <param name="developerId"></param>
        public ApiCall(string baseUrl,
            IWebClient client,
            string bearerToken = null,
            string developerId = null,
            string apiKey = null)
        {
            _baseUri = new Uri(baseUrl);

            if (bearerToken == string.Empty)
            {
                // Prevent users from bypassing null checks by setting empty strings instead.
                throw new ArgumentException("Invalid value supplied for bearer token.", "bearerToken");
            }

            _bearerToken = bearerToken;

            _developerId = developerId;
            _apiKey = apiKey;
            RequiresAuthentication = true;

           WebClientInstance = client;
        }

        /// <summary>
        ///  Get or Set NotFound Status.
        /// </summary>
        /// <value>
        /// NotFound Status true or false.
        /// </value>
        public bool NotFound { get; private set; }

        /// <summary>
        ///  Get or Set RequiresAuthentication Status.
        /// </summary>
        /// <value>
        /// True or false.
        /// </value>
        public bool RequiresAuthentication { get; set; }

        /// <summary>
        ///  Get or Set ServerError Status.
        /// </summary>
        /// <value>
        /// True or false.
        /// </value>
        public bool ServerError { get; private set; }

        /// <summary>
        ///  Get or Set Unauthorized Status.
        /// </summary>
        /// <value>
        /// True or false.
        /// </value>
        public bool Unauthorized { get; private set; }

        /// <summary>
        ///  Get or Set WebClientInstance Status.
        /// </summary>
        /// <value>
        /// True or false.
        /// </value>
        public IWebClient WebClientInstance { get; set; }

        /// <summary>
        /// Method MakeCall.
        /// </summary>
        protected virtual T MakeCall<T>(string apiPath) where T : class
        {
            var url = new Uri(_baseUri, apiPath);
            try
            {
                var data = MakeCall(wc => wc.DownloadString(url));
                if (data != null)
                {
                    return data.ToObject<T>();
                }
            }
            catch (SnapSdkException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new SnapSdkException("Unable to load api at url: " + url, ex);
            }

            return null;
        }

        /// <summary>
        /// Method MakeCall.
        /// </summary>
        /// <param name="arguments"></param>
        /// <param name="pathFormat"></param>
        
        protected virtual JObject MakeCall(string pathFormat, params object[] arguments)
        {
            return MakeCall(string.Format(pathFormat, arguments));
        }

        /// <summary>
        /// Method MakeCall.
        /// </summary>
        /// <param name="apiPath"></param>
        protected virtual JObject MakeCall(string apiPath)
        {
            var url = new Uri(_baseUri, apiPath);
            try
            {
                return MakeCall(wc => wc.DownloadString(url));
            }
            catch (SnapSdkException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new SnapSdkException("Unable to load api at url: " + url, ex);
            }
        }

        /// <summary>
        /// Method MakeCall.
        /// </summary>
        /// <param name="executeFunc"></param>
        
        protected JObject MakeCall(Func<IWebClient, string> executeFunc)
        {
            // Allow domains we don't have a certificate for
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            SetHeaders(WebClientInstance);
            return MakeCall(WebClientInstance, executeFunc);
        }

        private void SetHeaders(IWebClient wc)
        {
            if (RequiresAuthentication || !string.IsNullOrEmpty(_bearerToken))
            {
                AddHeader(wc, "Authorization", "Bearer " + _bearerToken);
            }

            AddHeader(wc, "X-Developer-Id", _developerId);
            AddHeader(wc, "X-Api-Key", _apiKey);
        }

        private void AddHeader(IWebClient wc, string name, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                wc.Headers[name] = value;
            }
        }

        private string ParseWebException(WebException wex)
        {
            var response = wex.Response as HttpWebResponse;
            if (response == null)
            {
                throw new Exception("No response from the API.", wex);
            }

            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                {
                    Debug.WriteLine("Four, oh Four...");
                    NotFound = true;
                    break;
                }

                case HttpStatusCode.Unauthorized:
                {
                    Debug.WriteLine("Unauthorized");
                    Unauthorized = true;
                    break;
                }

                case HttpStatusCode.InternalServerError:
                {
                    Debug.WriteLine("Piper down!");
                    ServerError = true;
                    throw new SnapSdkException("There was an error on the API service.", wex);
                }
                default:
                {
                    if (wex.Response != null)
                    {
                        throw new SnapSdkException(
                            $"Unhandled exception when making API call. {((HttpWebResponse)wex.Response).StatusCode} - {((HttpWebResponse)wex.Response).StatusDescription}.",
                            wex);
                    }

                    throw new SnapSdkException(
                        $"Unhandled exception when making API call.",
                        wex);

                }
            }

            using (var stream = response.GetResponseStream())
            {
                Debug.Assert(stream != null);
                var buf = new byte[response.ContentLength];

                // Fixes S2674 http://www.sonarlint.org/visualstudio/rules/index.html#version=1.10.0&ruleId=S2674
                using (var memory = new MemoryStream())
                {
                    int read;
                    do
                    {
                        read = stream.Read(buf, 0, (int)response.ContentLength);
                        memory.Write(buf, 0, read);
                    } while (read > 0);

                    return (Encoding.Default.GetString(memory.ToArray()));
                }
            }
        }

        /// <summary>
        /// Method MakeCall.
        /// </summary>
        /// <param name="executeFunc"></param>
        /// <param name="wc"></param>
        protected JObject MakeCall(IWebClient wc, Func<IWebClient, string> executeFunc)
        {
            try
            {
                var responseBody = executeFunc.Invoke(wc);
                if (!string.IsNullOrEmpty(responseBody))
                {
                    if (!responseBody.StartsWith("{"))
                    {
                        responseBody = string.Format("{{data:{0}}}", responseBody);
                    }

                    var o = JObject.Parse(responseBody);
                    return o;
                }
            }
            catch (WebException wex)
            {
                var errorMessage = ParseWebException(wex);
                throw new SnapSdkException(errorMessage, wex);
            }

            return null;
        }

        /// <summary>
        /// Method Put.
        /// </summary>
        /// <param name="apiPath"></param>
        /// <param name="data"></param>
        protected virtual JObject Put(string apiPath, object data)
        {
            return UploadData(apiPath, "PUT", data);
        }

        /// <summary>
        /// Method Post.
        /// </summary>
        /// <param name="apiPath"></param>
        /// <param name="data"></param>
        protected virtual JObject Post(string apiPath, object data)
        {
            return UploadData(apiPath, "POST", data);
        }

        /// <summary>
        /// Method Delete.
        /// </summary>
        /// <param name="apiPath"></param>
        /// <param name="data"></param>
        protected virtual JObject Delete(string apiPath, object data = null)
        {
            return UploadData(apiPath, "DELETE", data);
        }

        /// <summary>
        /// Method UploadData.
        /// </summary>
        /// <param name="apiPath"></param>
        /// <param name="data"></param>
        /// <param name="method"></param>
        private JObject UploadData(string apiPath, string method, object data)
        {
            var url = new Uri(_baseUri, apiPath);
            try
            {
                return MakeCall(wc =>
                {
                    // Allow domains we don't have a certificate for
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                    if (RequiresAuthentication)
                    {
                        wc.Headers[HttpRequestHeader.Authorization] = "Bearer " + _bearerToken;
                    }

                    wc.Headers[HttpRequestHeader.ContentType] = "application/json";

                    return wc.UploadString(url, method, JsonConvert.SerializeObject(data));
                });
            }
            catch (SnapSdkException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new SnapSdkException("Unable to load api at url: " + url, ex);
            }
        }

        #region <T>

        protected virtual T Put<T>(string apiPath, object data) where T : class
        {
            return UploadData<T>(apiPath, "PUT", data);
        }

        protected virtual T Post<T>(string apiPath, object data) where T : class
        {
            return UploadData<T>(apiPath, "POST", data);
        }

        protected virtual T Delete<T>(string apiPath, object data) where T : class
        {
            return UploadData<T>(apiPath, "DELETE", data);
        }

        protected T MakeCall<T>(Func<IWebClient, string> executeFunc) where T : class
        {
            // Allow domains we don't have a certificate for
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            SetHeaders(WebClientInstance);
            return MakeCall<T>(WebClientInstance, executeFunc);
        }

        private T UploadData<T>(string apiPath, string method, object data) where T : class
        {
            var url = new Uri(_baseUri, apiPath);
            try
            {
                return MakeCall<T>(wc =>
                {
                    // Allow domains we don't have a certificate for
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                    if (RequiresAuthentication)
                    {
                        wc.Headers[HttpRequestHeader.Authorization] = "Bearer " + _bearerToken;
                    }

                    wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                    var request = JsonConvert.SerializeObject(data);
                    return wc.UploadString(url, method, request);
                });
            }
            catch (SnapSdkException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new SnapSdkException("Unable to load api at url: " + url, ex);
            }
        }

        protected T MakeCall<T>(IWebClient wc, Func<IWebClient, string> executeFunc) where T : class
        {
            try
            {
                var responseBody = executeFunc.Invoke(wc);
                if (!string.IsNullOrEmpty(responseBody))
                {
                    if (!responseBody.StartsWith("{"))
                    {
                        responseBody = string.Format("{{data:{0}}}", responseBody);
                    }

                    var o = JsonConvert.DeserializeObject<T>(responseBody);
                    return o;
                }
            }
            catch (WebException wex)
            {
                var errorMessage = ParseWebException(wex);
                throw new SnapSdkException(errorMessage, wex);
            }

            return null;
        }

        #endregion
    }
}
