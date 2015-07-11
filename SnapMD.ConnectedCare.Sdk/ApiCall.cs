//    Copyright 2015 SnapMD, Inc.
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
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SnapMD.ConnectedCare.Sdk.Interfaces;

namespace SnapMD.ConnectedCare.Sdk
{
    //replace all calls and references to webclient, with WebClientWrapper, 
    //and route them through the wrapper.

    public class ApiCall
    {
        private readonly string _apiKey;
        private readonly Uri _baseUri;
        private readonly string _bearerToken;
        private readonly string _developerId;

        public IWebClient WebClientInstance { get; set; }

        public ApiCall(string baseUrl, IWebClient client, string bearerToken = null, string developerId = null, string apiKey = null)
        {
            _baseUri = new Uri(baseUrl);
            _bearerToken = bearerToken;
            _developerId = developerId;
            _apiKey = apiKey;
            RequiresAuthentication = true;

            WebClientInstance = client;
        }

        public ApiCall(string baseUrl, IWebClient client)
        {
            _baseUri = new Uri(baseUrl);
            RequiresAuthentication = true;
            WebClientInstance = client;
        }

        public bool RequiresAuthentication { get; set; }
        public bool NotFound { get; private set; }
        public bool ServerError { get; private set; }

        protected virtual T MakeCall<T>(string apiPath)
        {
            var url = new Uri(_baseUri, apiPath);
            try
            {
                var data = MakeCall(wc => wc.DownloadString(url));
                return JsonConvert.DeserializeObject<T>(data.ToString());
            }
            catch (Exception ex)
            {
                throw new SnapSdkException("Unable to load api at url: " + url, ex);
            }
        }

        protected virtual JObject MakeCall(string apiPath)
        {
            var url = new Uri(_baseUri, apiPath);
            try
            {
                return MakeCall(wc => wc.DownloadString(url));
            }
            catch (Exception ex)
            {
                throw new SnapSdkException("Unable to load api at url: " + url, ex);
            }
        }

        public WebResponse Response(WebRequest request)
        {
            try
            {
                var response = request.GetResponse();

                //var response = new System.Net.HttpWebResponse();

                System.IO.Stream stream = response.GetResponseStream();

                string val = "this is a response";

                byte[] valByte = System.Text.Encoding.UTF8.GetBytes(val);
                stream.Write(valByte, 0, valByte.Length);

                return response;
            }
            catch (Exception ex) { return null; }
        }

        protected JObject MakeCall(Func<IWebClient, string> executeFunc)
        {
            //Make Injectible
            //using (var wc = new MockWebClient(Response))
            //{
            //    // Allow domains we don't have a certificate for
            //    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            //    SetHeaders(wc);
            //    return MakeCall(wc, executeFunc);
            //}


            // Allow domains we don't have a certificate for
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            SetHeaders(WebClientInstance);
            return MakeCall(WebClientInstance, executeFunc);
        }

        private void SetHeaders(IWebClient wc)
        {
            AddHeader(wc, "Authorization", "Bearer " + _bearerToken);
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

        private void Parse404(WebException wex)
        {
            var response = wex.Response as HttpWebResponse;
            if (response == null)
            {
                throw new Exception("No response from the API.", wex);
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                Debug.WriteLine("Four, oh Four...");
                NotFound = true;
            }

            if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                Debug.WriteLine("Piper down!");
                ServerError = true;
                throw new SnapSdkException("There was an error on the API service.", wex);
            }
        }

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
                Parse404(wex);
            }

            return null;
        }

        protected virtual JObject Put(string apiPath, object data)
        {
            return UploadData(apiPath, "PUT", data);
        }

        protected virtual JObject Post(string apiPath, object data)
        {
            return UploadData(apiPath, "POST", data);
        }

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
            catch (Exception ex)
            {
                throw new SnapSdkException("Unable to load api at url: " + url, ex);
            }
        }
    }
}