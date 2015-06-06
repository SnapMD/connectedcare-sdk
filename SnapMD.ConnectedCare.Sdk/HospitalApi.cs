using System;
using Newtonsoft.Json.Linq;

namespace SnapMD.Sdk
{
    public class HospitalApi : ApiCall
    {
        public HospitalApi(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
        }

        public string GetAddress()
        {
            var o = MakeCall("hospitaladdress");
            return Convert.ToString(o["data"]);
        }

        public string GetHospitalAddressById(int hospitalId)
        {
            var o = MakeCall("HospitalAddress/" + hospitalId);
            var data = o["data"];
            return Convert.ToString(data["addressText"]);
        }

        public JObject GetHospital()
        {
            var o = MakeCall("hospital");
            return o;
        }
    }
}