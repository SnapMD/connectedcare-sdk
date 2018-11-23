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
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    /// Return encounter admin api.
    /// </summary>
    public class EncountersApi : ApiCall
    {
        /// <summary>
        /// EncounterAdminApi constructor
        /// </summary>
        public EncountersApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// EncounterAdminApi constructor
        /// </summary>
        public EncountersApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Update Intake Questionnaire
        /// </summary>
        public void UpdateIntakeQuestionnaire(int consultationId, object intakeData)
        {
            var url = string.Format("v2/patients/consultations/{0}/intake", consultationId);
            Put(url, intakeData);
        }

        /// <summary>
        ///     Gets a list of running consultations for the user whether the user is a clinician or a patient.
        ///     There should be 0 or 1 results, but if there are more, this information can be used for
        ///     debugging.
        /// </summary>
        /// <returns></returns>
        public ApiResponseV2<PatientConsultationInfo> GetUsersActiveConsultations()
        {
            const string url = "v2/consultations/running";
            var result = MakeCall<ApiResponseV2<PatientConsultationInfo>>(url);
            return result;
        }

        /// <summary>
        /// Return Schedule Consultation
        /// </summary>
        public ApiResponseV2<ScheduledConsultation> GetScheduledConsultations()
        {
            return MakeCall<ApiResponseV2<ScheduledConsultation>>("v2/patients/scheduledconsultations");
        }
    }
}
