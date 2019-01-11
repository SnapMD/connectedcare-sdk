#region Copyright
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
#endregion

using System;
using SnapMD.VirtualCare.Sdk.Models;
using SnapMD.VirtualCare.ApiModels.Scheduling;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The object used to encapsulate a consultation result.
    /// </summary>
    public class ConsultationResult
    {
        /// <summary>
        /// The assign doctor for consultation.
        /// </summary>
        public ResponseObservableItem AssignedDoctor { get; set; }

        /// <summary>
        /// The conference key of the consultation.
        /// </summary>
        public string ConferenceKey { get; set; }

        /// <summary>
        /// Consultation Status.
        /// </summary>
        /// <remarks>
        /// 1. PaymentDone = 68
        /// 2. DoctorAssigned = 69
        /// 3. CustomerInWaiting = 82
        /// 4. DoctorInitiatedConsultation = 70
        /// 5. StartedConsultation = 71
        /// 6. EndedConsultation = 72
        /// </remarks>
        public ConsultationStatusCode ConsultationStatus { get; set; }

        /// <summary>
        /// The Hospital Id.
        /// </summary>
        public int HospitalId { get; set; }

        /// <summary>
        /// The Consulation Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The Consulation is scheduled or ondemand.
        /// </summary>
        public string IsScheduled { get; set; }

        /// <summary>
        /// Not of the consulation
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Response obserable patient.
        /// </summary>
        /// <remarks>
        /// 1. Id
        /// 2. Description
        /// 3. ShortName
        /// </remarks>
        public ResponseObservableItem Patient { get; set; }

        /// <summary>
        /// Phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Response obserable User.
        /// </summary>
        /// <remarks>
        /// 1. Id
        /// 2. Description
        /// 3. ShortName
        /// </remarks>
        public ResponseObservableItem ResponsibleUser { get; set; }

        /// <summary>
        /// Consultation Time
        /// </summary>
        public DateTime? Time { get; set; }

        /// <summary>
        /// Copay Amount
        /// </summary>
        public double? CopayAmount { get; set; }

        /// <summary>
        /// Consultation Ammount
        /// </summary>
        public double? ConsultationAmount { get; set; }

        /// <summary>
        /// Encounter type code.
        /// </summary>
        /// <remarks>
        /// 1. None
        /// 2. Text
        /// 3. Vedio
        /// 4. Chat
        /// 5. Phone
        /// 6.InPerson
        /// </remarks>
        public EncounterTypeCode EncounterTypeCode { get; set; }
    }
}
