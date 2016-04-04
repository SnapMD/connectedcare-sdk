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

using System.Net;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Models;
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    public class PatientAdminApi : ApiCall, IPatientAdminApi
    {
        public PatientAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public PatientAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        public ApiResponse<PatientOnBoardShortDetail> GetPatient(string email)
        {
            var url = string.Format("v2/admin/patients?email={0}", email);
            return MakeCall<ApiResponse<PatientOnBoardShortDetail>>(url);
        }

        public ApiResponseV2<AddPatientAdminResponseShort> AddPatient(PatientOnBoardShortDetail patient)
        {
            if (patient.ValidateModel())
            {
                return Post<ApiResponseV2<AddPatientAdminResponseShort>>("v2/admin/patients", patient);
            }
            
            throw new SnapSdkException("Patient model is missing values");
            
        }

        public void DeletePatient(int patientId)
        {
            Delete<PatientOnBoardShortDetail>($"v2/admin/patients/{patientId}", null);
        }
    }
}