using System;

namespace SnapMD.Sdk
{
    public class HospitalCall : ApiCall
    {
        private readonly Uri _baseUri;

        public HospitalCall(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
            _baseUri = new Uri(baseUrl);
        }

        public string GetHospitalAddress()
        {
            var o = MakeCall("hospital/address");
            return Convert.ToString(o["data"]);
        }
    }
}