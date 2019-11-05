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
namespace SnapMD.VirtualCare.Sdk.Models
{
    /// <summary>
    /// Provide status code 
    /// </summary>
    public enum ConsultationStatusCode
    {
        /// <summary>
        /// Payment Done.
        /// </summary>
        /// <value>
        /// code is 68.
        /// </value>
        PaymentDone = 68,
        /// <summary>
        /// Doctor assigned.
        /// </summary>
        /// <value>
        /// code is 69.
        /// </value>
        DoctorAssigned = 69,
        /// <summary>
        /// Doctor Initiated Consultation.
        /// </summary>
        /// <value>
        /// Code is 70.
        /// </value>
        DoctorInitiatedConsultation = 70,
        /// <summary>
        /// Started Consultation .
        /// </summary>
        /// <value>
        /// Code is 71.
        /// </value>
        StartedConsultation = 71,
        /// <summary>
        /// Ended Consultation .
        /// </summary>
        /// <value>
        /// Code is 72.
        /// </value>
        EndedConsultation = 72,
        /// <summary>
        /// Cancel Consultation .
        /// </summary>
        /// <value>
        /// Code is 79.
        /// </value>
        CancelConsultaion = 79,
        /// <summary>
        /// Progress Consultation .
        /// </summary>
        /// <value>
        /// Code is 80.
        /// </value>
        InProgress = 80,
        /// <summary>
        /// Dropped Consultation .
        /// </summary>
        /// <value>
        /// Code is 81.
        /// </value>
        DroppedConsultation = 81,
        /// <summary>
        /// Cutomer in waiting.
        /// </summary>
        /// <value>
        /// Code is 82.
        /// </value>
        CustomerInWaiting = 82,
        /// <summary>
        /// Disconnected Consultation .
        /// </summary>
        /// <value>
        /// Code is 83.
        /// </value>
        DisconnectedConsultation = 83,
        /// <summary>
        /// Doctor Review Consultation .
        /// </summary>
        /// <value>
        /// Code is 154.
        /// </value>
        DoctorReviewConsultation = 154,
        /// <summary>
        /// Dismissed Consultation .
        /// </summary>
        /// <value>
        /// Code is 163.
        /// </value>
        Dismissed = 163,
        /// <summary>
        /// Provider Did Not Attend Consultation.
        /// </summary>
        /// <value>
        /// Code is 199.
        /// </value>
        ProviderDNA = 199,
    };
}
