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
using Newtonsoft.Json.Linq;

namespace SnapMD.ConnectedCare.Sdk.Reports
{
    public class SnapReportsApi : ApiCall
    {
        public SnapReportsApi(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, new SnapMD.ConnectedCare.Sdk.Wrappers.WebClientWrapper(new System.Net.WebClient()), bearerToken, developerId, apiKey)
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
        
        public string GetCounsultationFiles(int consultationId)
        {
            var jsonObject = new JObject();
            jsonObject.Add("consultationId", consultationId);

            jsonObject = Post("Folder/GetConsultation", jsonObject);
            return Convert.ToString(jsonObject);
        }
    }
}