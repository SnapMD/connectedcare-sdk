using System;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SnapMD.Sdk
{
    public class ApiCall
    {
        private readonly string _apiKey;
        private readonly string _baseUrl;
        private readonly string _bearerToken;
        private readonly string _developerId;

        public ApiCall(string baseUrl, string bearerToken = null, string developerId = null, string apiKey = null)
        {
            _baseUrl = baseUrl;
            _bearerToken = bearerToken;
            _developerId = developerId;
            _apiKey = apiKey;
            RequiresAuthentication = true;
        }

        public ApiCall(string baseUrl)
        {
            _baseUrl = baseUrl;
            RequiresAuthentication = true;
        }

        public bool RequiresAuthentication { get; set; }
        public bool NotFound { get; private set; }
        public bool ServerError { get; private set; }

        protected virtual T MakeCall<T>(string apiPath)
        {
            var baseUrl = new Uri(_baseUrl);
            var url = new Uri(baseUrl, apiPath);
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
            var baseUrl = new Uri(_baseUrl);
            var url = new Uri(baseUrl, apiPath);
            try
            {
                return MakeCall(wc => wc.DownloadString(url));
            }
            catch (Exception ex)
            {
                throw new SnapSdkException("Unable to load api at url: " + url, ex);
            }
        }

        protected JObject MakeCall(Func<WebClient, string> executeFunc)
        {
            using (var wc = new WebClient())
            {
                // Allow domains we don't have a certificate for
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                SetHeaders(wc);
                return MakeCall(wc, executeFunc);
            }
        }

        private void SetHeaders(WebClient wc)
        {
            AddHeader(wc, "Authorization", "Bearer " + _bearerToken);
            AddHeader(wc, "X-Developer-Id", _developerId);
            AddHeader(wc, "X-Api-Key", _apiKey);
        }

        private void AddHeader(WebClient wc, string name, string value)
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

        protected JObject MakeCall(WebClient wc, Func<WebClient, string> executeFunc)
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
            var baseUrl = new Uri(_baseUrl);
            var url = new Uri(baseUrl, apiPath);
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