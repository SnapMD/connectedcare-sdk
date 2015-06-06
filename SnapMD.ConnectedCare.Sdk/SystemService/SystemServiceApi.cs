using System;

namespace SnapMD.Sdk
{
    public class SystemServiceApi : ApiCall
    {
        public SystemServiceApi(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
        }

        public string GetServiceList()
        {
            var o = MakeCall("systemservice/all");
            return Convert.ToString(o["ServiceList"]);
        }

        public string UpdateSystemStatus(object data)
        {
            var o = Post("systemservice/updatestatus", data);
            return string.Empty;
        }
    }
}