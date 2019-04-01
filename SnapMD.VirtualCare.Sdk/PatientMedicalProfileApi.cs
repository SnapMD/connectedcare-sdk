//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Interfaces;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    /// Represents Patient Medical Profile Api Information.
    /// </summary>
    public class PatientMedicalProfileApi : ApiCall
    {
        /// <summary>
        /// Constructor PatientMedicalProfileApi.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUrl"></param>
        /// <param name="bearerToken"></param>
        /// <param name="developerId"></param>
        /// <param name="webClient"></param>
        public PatientMedicalProfileApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Get Patient Data.
        /// </summary>
        /// <param name="patientId"></param>
        public ApiResponseV2<PatientMedicalHistoryProfile> GetPatientData(int patientId)
        {
            var url = string.Format("v2/patients/medicalprofile/{0}", patientId);
            var result = MakeCall<ApiResponseV2<PatientMedicalHistoryProfile>>(url);
            return result;
        }

        /// <summary>
        ///  Update Patient Data
        /// </summary>
        /// <param name="patientId"></param>
        /// <param name="profile"></param>
        public ApiResponseV2<PatientMedicalHistoryProfile> UpdatePatientData(int patientId, IPatientMedicalHistoryProfile profile)
        {
            var url = string.Format("v2/patients/medicalprofile/{0}", patientId);
            var result = Put(url, profile).ToObject<PatientMedicalHistoryProfile>();
            return new ApiResponseV2<PatientMedicalHistoryProfile>(result);
        }
    }
}
