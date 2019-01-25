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

using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Represents the OnDemandResponse.
    /// </summary>
    public class OnDemandResponse
    {
        /// <summary>
        ///     Get or Set the Consultation Amount.
        /// </summary>
        /// <value>
        ///   Consultation Amount
        /// </value>
        public double? ConsultationAmount { get; set; }
        /// <summary>
        ///     Get or Set the Consultation Id.
        /// </summary>
        /// <value>
        ///   Consultation Id
        /// </value>
        public int ConsultationId { get; set; }
        /// <summary>
        ///     Get or Set the On Demand Request Id.
        /// </summary>
        /// <value>
        ///   On Demand Request Id
        /// </value>
        public Guid OnDemandRequestId { get; set; }
        /// <summary>
        ///     Get or Set Patient Queue Entry Id.
        /// </summary>
        /// <value>
        ///  Patient Queue Entry Id
        /// </value>
        public Guid PatientQueueEntryId { get; set; }
        /// <summary>
        ///     Get or Set Patient Person Id.
        /// </summary>
        /// <value>
        ///  Patient Person Id
        /// </value>
        public Guid PatientPersonId { get; set; }
        /// <summary>
        ///     Get or Set Patient Person Id.
        /// </summary>
        /// <value>
        ///  Patient Person Id
        /// </value>
        public Guid MeetingId { get; set; }
        /// <summary>
        ///     Get or Set Appointment Id.
        /// </summary>
        /// <value>
        ///  Appointment Id
        /// </value>
        public Guid? AppointmentId { get; set; }
    }
}
