using System;
using Newtonsoft.Json.Linq;

namespace SnapMD.ConnectedCare.Sdk.ReportApi
{
    public class SnapReportApi : ApiCall
    {
        public SnapReportApi(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, bearerToken, developerId, apiKey)
        {
        }

        public string GetPatientConsultationReportDetails(int consultationId)
        {
            var url = string.Format("reports/consultationreportdetails/{0}", consultationId);
            var o = MakeCall(url);
            var result = Convert.ToString(o["data"]);
            return result;
        }

        public string GetPatientConsultationChatNote(int consultationId)
        {
            var url = string.Format("reports/consultationreportdetails/chatnote/{0}", consultationId);
            var o = MakeCall(url);
            var result = Convert.ToString(o["data"]);
            return result;
        }

        public string GetPatientConsultationReport(int consultationId)
        {
            var url = string.Format("reports/consultationreport/{0}", consultationId);
            var o = MakeCall(url);
            var result = Convert.ToString(o["data"]);
            return result;
        }

        public string GetCounsultationFiles(int consultationId)
        {
            var jsonObject = new JObject();
            jsonObject.Add("consultationId", consultationId);

            jsonObject = Post("Folder/GetConsultation", jsonObject);
            return Convert.ToString(jsonObject);
        }
    }
}