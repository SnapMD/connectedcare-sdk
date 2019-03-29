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

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Represents Schedule Consultation Detail By Username.
    /// </summary>
    public class ScheduleConsultationDetailByUsername
    {
        /// <summary>
        ///    Get or Set the Assigned Doctor User name
        /// </summary>
        public string AssignedDoctorUsername { get; set; }
        /// <summary>
        ///     Get or Set the Consultation Id.
        /// </summary>
        /// <value>
        ///    ConsultationId
        /// </value>
        public int? ConsultationId { get; set; }
        /// <summary>
        ///     Get or Set the Doctor Name.
        /// </summary>
        /// <value>
        ///    DoctorName
        /// </value>
        public string DoctorName { get; set; }
        /// <summary>
        ///     Get or Set the Id.
        /// </summary>
        /// <value>
        ///    Id
        /// </value>
        public int Id { get; set; }

        /// <summary>
        ///     Get or Set IsNoCharge.
        /// </summary>
        /// <value>
        ///    IsNoCharge
        /// </value>
        public bool IsNoCharge { get; set; }
        /// <summary>
        ///     Get or Set Note.
        /// </summary>
        /// <value>
        ///    Note
        /// </value>
        public string Note { get; set; }
        
        /// <summary>
        ///     Get or Set Patient.
        /// </summary>
        /// <value>
        ///    Patient
        /// </value>
        public PatientShortInfo Patient { get; set; }

        /// <summary>
        ///     Get or Set Patient Username.
        /// </summary>
        /// <value>
        ///    PatientUsername
        /// </value>
        public string PatientUsername { get; set; }
       
        /// <summary>
        ///     Get or Set Prev Consultation ID.
        /// </summary>
        /// <value>
        ///    PrevConsultationID
        /// </value>
        public int? PrevConsultationID { get; set; }
        
        /// <summary>
        ///     Get or Set  Primary Consern.
        /// </summary>
        /// <value>
        ///    PrimaryConsern
        /// </value>
        public string PrimaryConsern { get; set; }

        /// <summary>
        ///     Get or Set ProfileImagePath.
        /// </summary>
        /// <value>
        ///    ProfileImagePath
        /// </value>
        public string ProfileImagePath { get; set; }

        /// <summary>
        ///     Get or Set ScheduledFrom.
        /// </summary>
        /// <value>
        ///    ScheduledFrom
        /// </value>
        public string ScheduledFrom { get; set; }

        /// <summary>
        ///     Get or Set ScheduledTime.
        /// </summary>
        /// <value>
        ///    ScheduledTime
        /// </value>
        public DateTime? ScheduledTime { get; set; }

        /// <summary>
        ///     Get or Set SchedulingReasonType.
        /// </summary>
        /// <value>
        ///    SchedulingReasonType
        /// </value>
        public int? SchedulingReasonType { get; set; }
        
        /// <summary>
        ///     Get or Set SecondaryConsern.
        /// </summary>
        /// <value>
        ///    SecondaryConsern
        /// </value>
        public string SecondaryConsern { get; set; }
    }
}
