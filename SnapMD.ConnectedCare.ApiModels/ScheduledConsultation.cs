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

using System;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class ScheduledConsultation
    {
        public DateTimeOffset ScheduledTime { get; set; }
        public int ExpiryTime { get; set; }
        public int ConsultantUserId { get; set; }
        public int ConsultationId { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public TimeZoneInfo UserTimeZone { get; set; }
        public int PatientId { get; set; }
        public string AssignedDoctorFirstName { get; set; }
        public string AssignedDoctorLastName { get; set; }
        public string AssignedDoctorName { get;set; }
        public string PatientName { get; set; }
        public int? PatientUserId { get; set; }
        public int ScheduledId { get; set; }
        public double? ConsultationAmount { get; set; }
        public double? CopayAmount { get; set; }
        public int? ConsultationStatus { get; set; }
    }
}