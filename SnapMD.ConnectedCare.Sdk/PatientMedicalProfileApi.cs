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

using SnapMD.ConnectedCare.ApiModels;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.Sdk
{
    public class PatientMedicalProfileApi : ApiCall
    {
        public PatientMedicalProfileApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public ApiResponseV2<PatientMedicalHistoryProfile> GetPatientData(int patientId)
        {
            var url = string.Format("v2/patients/medicalprofile/{0}", patientId);
            var result = MakeCall<ApiResponseV2<PatientMedicalHistoryProfile>>(url);
            return result;
        }

        public ApiResponseV2<PatientMedicalHistoryProfile> UpdatePatientData(int patientId, IPatientMedicalHistoryProfile profile)
        {
            var url = string.Format("v2/patients/medicalprofile/{0}", patientId);
            var result = Put(url, profile).ToObject<PatientMedicalHistoryProfile>();
            return new ApiResponseV2<PatientMedicalHistoryProfile>(result);
        }
    }
}
