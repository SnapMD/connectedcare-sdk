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

using System.Net;
using SnapMD.ConnectedCare.ApiModels;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;
using SnapMD.ConnectedCare.Sdk.Wrappers;

namespace SnapMD.ConnectedCare.Sdk
{
    public class PatientAdminApi : ApiCall
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

        public void AddPatient(PatientOnBoardShortDetail patient)
        {
            Post("v2/admin/patients", patient);
        }

        public void DeletePatient(int patientId)
        {
            Delete<PatientOnBoardShortDetail>(string.Format("v2/admin/patients/{0}", patientId), null);
        }
    }
}