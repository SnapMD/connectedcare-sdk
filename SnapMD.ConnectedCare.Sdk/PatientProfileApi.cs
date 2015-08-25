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
using Newtonsoft.Json.Linq;
using SnapMD.ConnectedCare.ApiModels;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.Sdk
{
    public class PatientProfileApi : ApiCall
    {
        public PatientProfileApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public JObject AddPatient(object newPatient)
        {
            // Todo: Create a request object to pass the data.
            return Post("patients/profile", newPatient);
        }

        // todo: short time implementatin. this has to remove eventually: Han
        // chrisc: updated this with the V2 call from original V1 call
        public ApiResponseV2<GetPatientsResponse> GetPatientData(int PatientId)
        {
            var url = string.Format("v2/patients/profiles/{0}", PatientId);
            var result = MakeCall<ApiResponseV2<GetPatientsResponse>>(url);
            return result;
        }

        // todo: short time implementation: only update organization & location for user
        public string UpdateUserProfile(object data)
        {
            var o = Post("patients/updateuserprofile", data);
            return string.Empty;
        }
    }
}