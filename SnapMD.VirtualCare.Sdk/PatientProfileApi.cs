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
using SnapMD.VirtualCare.Sdk.Models;
using SnapMD.Web.Api.Models;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    /// Patient Profile Api .
    /// </summary>
    public class PatientProfileApi : ApiCall, IPatientProfileApi
    {
        /// <summary>
        /// Patient Profile Api Constructor.
        /// </summary>
        /// <param name="apiKey">Key</param>
        /// <param name="baseUrl">Url</param>
        /// <param name="bearerToken">Token</param>
        /// <param name="developerId">developer Id</param>
        /// <param name="webClient">Web Client </param>
        public PatientProfileApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Add Dependent.
        /// </summary>
        /// <param name="newPatient">Pateint Information </param>
        public ApiResponseV2<PatientProfileResponse> AddDependent(AddPatientProfileRequest newPatient)
        {
            return Post<ApiResponseV2<PatientProfileResponse>>("v2/familygroups/dependents", newPatient);
        }

        /// <summary>
        ///Get Patient Data.
        /// </summary>
        /// <param name="patientId">Pateint Id </param>
        public ApiResponseV2<GetPatientsResponse> GetPatientData(int patientId)
        {
            var url = string.Format("v2/patients/profiles/{0}", patientId);
            var result = MakeCall<ApiResponseV2<GetPatientsResponse>>(url);
            return result;
        }

        /// <summary>
        ///New Patient.
        /// </summary>
        /// <param name="request">Pateint Id </param>
        public ApiResponseV2<NewPatientResponse> NewPatient(NewPatientRequest request)
        {
            if (request.ValidateModel())
            {
                const string url = "v2/patients";
                var result = Post<ApiResponseV2<NewPatientResponse>>(url, request);
                return result;
            }

            throw new SnapSdkException("Model invalid");
        }

        /// <summary>
        /// Re-sends patient onboarding email.
        /// </summary>
        /// <returns>Returns user's email address.</returns>
        public ApiResponseV2<string> ResendOnboardingEmail(EmailUserRequest emailUserRequest)
        {
            return Post<ApiResponseV2<string>>("v2/patients/single-trip-registration/resend-onboarding-email", emailUserRequest);
        }
    }
}