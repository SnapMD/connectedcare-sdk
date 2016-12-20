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

using SnapMD.VirtualCare.ApiModels.Scheduling;
using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    public class PatientConsultationInfo
    {
        public int ConsultationId { get; set; }
        public Guid? MeetingId { get; set; }
        public Guid PatientPersonId { get; set; }
        public Guid ProviderPersonId { get; set; }
        public int PatientId { get; set; }
        public string SessionId { get; set; }
        public int ConsultantUserId { get; set; }
        public int AssignedDoctorId { get; set; }
        public string AssignedDoctorFirstName { get; set; }
        public string AssignedDoctorLastName { get; set; }

        public string AssignedDoctorName
        {
            get { return string.Format("{0} {1}", AssignedDoctorFirstName, AssignedDoctorLastName).Trim(); }
        }

        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }

        public string PatientName
        {
            get { return string.Format("{0} {1}", PatientFirstName, PatientLastName).Trim(); }
        }

        public DateTime? DOB { get; set; }
        public DateTime? CreatedDate { get; set; }

        public string ConsultationDate
        {
            get
            {
                // ConsultationTimeInfo time has valid date time (converted from TimeZone because it has both date and time)
                if (ConsultationTimeInfo.HasValue)
                {
                    return ConsultationTimeInfo.Value.ToString("MMM dd, yyyy");
                }
                return string.Empty;
            }
        }

        public DateTime? ConsultationTimeInfo { get; set; }

        public string ConsultationTime
        {
            get
            {
                if (ConsultationTimeInfo.HasValue)
                {
                    return ConsultationTimeInfo.Value.ToString(@"hh\:mm tt");
                }
                return string.Empty;
            }
        }

        public DateTime? WaitingConsultationInfo { get; set; }
        public DateTime? StartedConsultationInfo { get; set; }

        public string WaitingConsultation
        {
            get
            {
                if (WaitingConsultationInfo.HasValue)
                {
                    return WaitingConsultationInfo.Value.ToString("MMM dd, yyyy");
                }
                return string.Empty;
            }
        }

        public string StartedConsultation
        {
            get
            {
                if (StartedConsultationInfo.HasValue)
                {
                    return StartedConsultationInfo.Value.ToString(@"hh\:mm");
                }
                return string.Empty;
            }
        }

        public long? ConsultationDuration { get; set; }
        //Value from PatientProfile.IsDependent property.
        public bool IsDependent { get; set; }

        //Patient Guardians.
        public IEnumerable<Guardian> Guardians { get; set; }

        public Guid? AppointmentId { get; set; }

        public int? Status { get; set; }
        public int? DoctorStatus { get; set; }
        public int? PatientStatus { get; set; }

        public string PhoneNumber { get; set; }

        public string PhoneType { get; set; }

        public EncounterTypeCode EncounterTypeCode { get; set; }
    }

    public class Guardian
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public bool IsAuthorized { get; set; }
    }
}
