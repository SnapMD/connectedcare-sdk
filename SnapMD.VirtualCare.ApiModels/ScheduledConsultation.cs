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
    ///<summary>
    /// Encapsulate the ScheduleSlot.
    /// </summary>
    public class ScheduledConsultation
    {
        ///<summary>
        ///Get or set the Assigned Doctor First Name.
        /// </summary>
        /// <value>Assigned Doctor First Name</value>
        public string AssignedDoctorFirstName { get; set; }

        ///<summary>
        ///Get or set the Assigned Doctor Last Name.
        /// </summary>
        /// <value>Assigned Doctor Last Name</value>
        public string AssignedDoctorLastName { get; set; }

        ///<summary>
        ///Get or set the Assigned Doctor Name.
        /// </summary>
        /// <value>Assigned Doctor Namee</value>
        public string AssignedDoctorName { get; set; }

        ///<summary>
        ///Get or set Consultant User Id.
        /// </summary>
        /// <value>Consultant User Id</value>
        public int ConsultantUserId { get; set; }

        ///<summary>
        ///Get or set Consultation Amount.
        /// </summary>
        /// <value>Consultation Amount</value>
        public double? ConsultationAmount { get; set; }

        ///<summary>
        ///Get or set Consultation Id.
        /// </summary>
        /// <value>Consultation Id</value>
        public int ConsultationId { get; set; }

        ///<summary>
        ///Get or set Consultation Status.
        /// </summary>
        /// <value>Consultation Status</value>
        public int? ConsultationStatus { get; set; }

        ///<summary>
        ///Get or set Copay Amount.
        /// </summary>
        /// <value>Copay Amount</value>
        public double? CopayAmount { get; set; }

        ///<summary>
        ///Get or set Expiry Time.
        /// </summary>
        /// <value>Expiry Time</value>
        public int ExpiryTime { get; set; }


        ///<summary>
        ///Get or set Patient First Name.
        /// </summary>
        /// <value>Patient First Name</value>
        public string PatientFirstName { get; set; }

        ///<summary>
        ///Get or set Patient First Name.
        /// </summary>
        /// <value>Patient First Name</value>
        public int PatientId { get; set; }

        ///<summary>
        ///Get or set Patient Last Name.
        /// </summary>
        /// <value>Patient Last Name</value>
        public string PatientLastName { get; set; }

        ///<summary>
        ///Get or set Patient Name.
        /// </summary>
        /// <value>Patient Name</value>
        public string PatientName { get; set; }

        ///<summary>
        ///Get or set Patient UserId.
        /// </summary>
        /// <value>Patient UserId</value>
        public int? PatientUserId { get; set; }

        ///<summary>
        ///Get or set Scheduled Id.
        /// </summary>
        /// <value>Scheduled Id</value>
        public int ScheduledId { get; set; }

        ///<summary>
        ///Get or set Scheduled Time.
        /// </summary>
        /// <value>Scheduled Time</value>
        public DateTimeOffset ScheduledTime { get; set; }

        ///<summary>
        ///Get or set User Time Zone.
        /// </summary>
        /// <value>User Time Zone</value>
        public TimeZoneInfo UserTimeZone { get; set; }
    }
}
