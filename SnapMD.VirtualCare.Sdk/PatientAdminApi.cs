﻿//    Copyright 2016 SnapMD, Inc.
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
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    /// Represents Patient Admin Api.
    /// </summary>
    public class PatientAdminApi : ApiCall, IPatientAdminApi
    {
        /// <summary>
        /// Represents Patient Admin Api Constructor.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUrl"></param>
        /// <param name="bearerToken"></param>
        /// <param name="developerId"></param>
        /// <param name="webClient"></param>
        public PatientAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Represents Patient Admin Api Constructor.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUrl"></param>
        /// <param name="bearerToken"></param>
        /// <param name="developerId"></param>
        public PatientAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        ///    Get Patients.
        /// </summary>
        /// <value>
        ///   <paramref name="email"/>
        /// </value>
        public ApiResponse<PatientOnBoardShortDetail> GetPatient(string email)
        {
            var url = $"v2/admin/patients?email={email}";
            return MakeCall<ApiResponse<PatientOnBoardShortDetail>>(url);
        }

        /// <summary>
        ///    Add Patients.
        /// </summary>
        /// <value>
        ///   <paramref name="patient"/>
        /// </value>
        public ApiResponseV2<AddPatientAdminResponseShort> AddPatient(PatientOnBoardShortDetailRequest patient)
        {
            return AddPatient(patient, false);

        }

        /// <summary>
        ///    Add Patients.
        /// </summary>
        /// <value>
        ///   <paramref name="patient"/>
        ///   <paramref name="allowNullEmail"/>
        /// </value>
        public ApiResponseV2<AddPatientAdminResponseShort> AddPatient(PatientOnBoardShortDetailRequest patient, bool allowNullEmail)
        {
            if (patient.ValidateModel(message => new SnapSdkException(message), allowNullEmail))
            {
                return Post<ApiResponseV2<AddPatientAdminResponseShort>>("v2/admin/patients", patient);
            }

            throw new SnapSdkException("Patient model is missing values");

        }
        /// <summary>
        ///    Delete the Patient.
        /// </summary>
        /// <value>
        ///   <paramref name="patientId"/>
        /// </value>
        public void DeletePatient(int patientId)
        {
            Delete<PatientOnBoardShortDetailRequest>($"v2/admin/patients/{patientId}", null);
        }

        /// <summary>
        ///    Delete the Update Dependent Relation And Authorization.
        /// </summary>
        /// <value>
        ///   <paramref name="patientId"/>
        ///   <paramref name="dependentId"/>
        ///   <paramref name="requestData"/>
        /// </value>
        public ApiResponseV2<bool> UpdateDependentRelationAndAuthorization
            (int patientId, int dependentId, DependentRelationship requestData)
        {
            return
                new ApiResponseV2<bool>(
                    Put($"v2/admin/patient/{patientId}/dependent/{dependentId}/relationship", requestData)
                        .ToObject<bool>());
        }

    }

}
