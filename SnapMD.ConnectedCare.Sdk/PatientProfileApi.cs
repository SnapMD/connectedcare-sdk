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

using System.Linq;
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

        public ApiResponseV2<PatientProfileResponse> AddPatient(object newPatient)
        {
            // Todo: Create a request object to pass the data.
            // Todo: chrisc: the type passed is AddPatientProfileRequest, but it uses other classes that are heavily used in the WebApi 
            return Post<ApiResponseV2<PatientProfileResponse>>("v2/patients/profile", newPatient);
        }

        // todo: short time implementatin. this has to remove eventually: Han
        public ApiResponseV2<GetPatientsResponse> GetPatientData(int patientId)
        {
            var url = string.Format("v2/patients/profiles/{0}", patientId);
            var result = MakeCall<ApiResponseV2<GetPatientsResponse>>(url);
            return result;
        }

        // todo: short time implementation: only update organization & location for user
        public bool UpdateUserProfile(object data)
        {
            var o = Post<ApiResponseV2<bool>>("v2/patients/updateuserprofile", data);
            return o.Data.First();
        }
    }
}