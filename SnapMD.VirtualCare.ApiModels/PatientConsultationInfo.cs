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
    /// <summary>
    /// Represents Patient Consultation Information.
    /// </summary>
    public class PatientConsultationInfo
    {
        /// <summary>
        ///     Get or Set the ConsultationId .
        /// </summary>
        /// <value>
        ///    ConsultationId
        /// </value> 
        public int ConsultationId { get; set; }
        /// <summary>
        ///     Get or Set the Meeting Id .
        /// </summary>
        /// <value>
        ///    MeetingId
        /// </value> 
        public Guid? MeetingId { get; set; }
        /// <summary>
        ///     Get or Set the Patient PersonId .
        /// </summary>
        /// <value>
        ///    PatientPersonId
        /// </value> 
        public Guid PatientPersonId { get; set; }
        /// <summary>
        ///     Get or Set the ProviderPersonId .
        /// </summary>
        /// <value>
        ///    ProviderPersonId
        /// </value> 
        public Guid ProviderPersonId { get; set; }
        /// <summary>
        ///     Get or Set the PatientId .
        /// </summary>
        /// <value>
        ///    PatientId
        /// </value> 
        public int PatientId { get; set; }
        /// <summary>
        ///     Get or Set the SessionId .
        /// </summary>
        /// <value>
        ///    SessionId
        /// </value> 
        public string SessionId { get; set; }
        /// <summary>
        ///     Get or Set the ConsultantUserId .
        /// </summary>
        /// <value>
        ///    ConsultantUserId
        /// </value> 
        public int ConsultantUserId { get; set; }
        /// <summary>
        ///     Get or Set the Assigned Doctor Id .
        /// </summary>
        /// <value>
        ///   Doctor Id
        /// </value> 
        public int AssignedDoctorId { get; set; }
        /// <summary>
        ///     Get or Set the Assigned Doctor First Name .
        /// </summary>
        /// <value>
        ///    Doctor First Name
        /// </value> 
        public string AssignedDoctorFirstName { get; set; }
        /// <summary>
        ///     Get or Set the Assigned Doctor LastName .
        /// </summary>
        /// <value>
        ///    Doctor Last Name
        /// </value> 
        public string AssignedDoctorLastName { get; set; }
        /// <summary>
        ///     Get or Set the Proxy UserId .
        /// </summary>
        /// <value>
        ///   ProxyUserId
        /// </value> 
        public int? ProxyUserId { get; set; }

        /// <summary>
        ///     Get or Set the Assigned Doctor Name.
        /// </summary>
        /// <value>
        ///   Assigned Doctor Name
        /// </value> 
        public string AssignedDoctorName
        {
            get { return string.Format("{0} {1}", AssignedDoctorFirstName, AssignedDoctorLastName).Trim(); }
        }
        /// <summary>
        ///     Get or Set the Patient First Name.
        /// </summary>
        /// <value>
        ///  Patient First Name.
        /// </value> 

        public string PatientFirstName { get; set; }
        /// <summary>
        ///     Get or Set the Patient Last Name.
        /// </summary>
        /// <value>
        ///  Patient Last Name.
        /// </value> 
        public string PatientLastName { get; set; }

        /// <summary>
        ///     Get or Set the Patient Name.
        /// </summary>
        /// <value>
        ///  Patient Name.
        /// </value> 
        public string PatientName
        {
            get { return string.Format("{0} {1}", PatientFirstName, PatientLastName).Trim(); }
        }

        /// <summary>
        ///     Get or Set the DOB.
        /// </summary>
        /// <value>
        /// DOB.
        /// </value> 
        public DateTime? DOB { get; set; }
        /// <summary>
        ///     Get or Set Consultation create date
        /// </summary>
        /// <value>
        /// Consultation create date.
        /// </value> 
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        ///     Get or Set Consultation Update date
        /// </summary>
        /// <value>
        /// Consultation Update date.
        /// </value> 
        public DateTime? UpdatedDate { get; set; }

        /// <summary>
        ///     Get or Set ConsultationDate
        /// </summary>
        /// <value>
        /// Consultation date.
        /// </value> 
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

        /// <summary>
        ///     Get or Set Consultation Time Information
        /// </summary>
        /// <value>
        /// Consultation Time Information
        /// </value> 
        public DateTime? ConsultationTimeInfo { get; set; }

        /// <summary>
        ///     Get or Set Consultation Time.
        /// </summary>
        /// <value>
        /// Consultation Time.
        /// </value> 
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
        /// <summary>
        ///     How long ago provider was disconnected from consultation (minutes).
        /// </summary>
        /// <value>
        /// Consultation Disconncted Duration Time.
        /// </value> 
        public Double DisconnctedDuration { get; set; }

        /// <summary>
        ///     How long ago last patricipant (provider/patient/guest) was disconnected from consultations (minutes).
        /// </summary>
        public Double NoParticipantsDuration { get; set; }

        /// <summary>
        ///     Get or Set  Waiting Consultation Information.
        /// </summary>
        /// <value>
        ///  Waiting Consultation Information.
        /// </value>
        public DateTime? WaitingConsultationInfo { get; set; }
        /// <summary>
        ///     Get or Set Started Consultation  Information.
        /// </summary>
        /// <value>
        /// Consultation Started Consultation Information.
        /// </value>
        public DateTime? StartedConsultationInfo { get; set; }

        /// <summary>
        ///     Get or Set WaitingConsultation.
        /// </summary>
        /// <value>
        /// Consultation Waiting Consultation Information.
        /// </value>
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


        /// <summary>
        ///     Get or Set Started Consultation  Information.
        /// </summary>
        /// <value>
        /// Consultation Started Consultation Information.
        /// </value>
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

        /// <summary>
        ///     Get or Set Consultation Duration.
        /// </summary>
        /// <value>
        /// Consultation Duration.
        /// </value>
        public long? ConsultationDuration { get; set; }


        /// <summary>
        /// True, if patient and provider are connected to active consultation
        /// False, if either patient or proveder are not connected.
        /// Null for consultations which are not active (ended, dropped, dismissed etc.)
        /// </summary>
        public bool? IsCurrentlyConnected { get; set; }

        /// <summary>
        ///     Get or Set Consultation Duration.
        /// </summary>
        /// <value>
        /// Value from PatientProfile.IsDependent property.
        /// </value>
        public bool IsDependent { get; set; }

        /// <summary>
        ///     Get or Set Consultation Guardians.
        /// </summary>
        /// <value>
        /// Value from PatientProfile.Guardians property.
        /// </value>
        public IEnumerable<Guardian> Guardians { get; set; }
        /// <summary>
        ///     Get or Set Appointment Id
        /// </summary>
        /// <value>
        /// Value from PatientProfile.AppointmentId property.
        /// </value>

        public Guid? AppointmentId { get; set; }

        /// <summary>
        ///     Get or Set Status
        /// </summary>
        /// <value>
        /// Value from PatientProfile.Status property.
        /// </value>
        public int? Status { get; set; }
        /// <summary>
        ///     Get or Set DoctorStatus
        /// </summary>
        /// <value>
        /// Value from PatientProfile.DoctorStatus property.
        /// </value>
        public int? DoctorStatus { get; set; }
        /// <summary>
        ///     Get or Set Patient Status
        /// </summary>
        /// <value>
        /// Value from PatientProfile.PatientStatus property.
        /// </value>
        public int? PatientStatus { get; set; }

        /// <summary>
        ///     Get or Set PhoneNumber
        /// </summary>
        /// <value>
        /// Value from PatientProfile.PhoneNumber property.
        /// </value>
        public string PhoneNumber { get; set; }
        /// <summary>
        ///     Get or Set PhoneType
        /// </summary>
        /// <value>
        /// Value from PatientProfile.PhoneType property.
        /// </value>
        public string PhoneType { get; set; }

        /// <summary>
        ///     Get or Set Dismissed
        /// </summary>
        /// <value>
        /// Value from PatientProfile.Dismissed property.
        /// </value>
        public bool Dismissed { get; set; }

        /// <summary>
        ///     Get or Set AppointmentType
        /// </summary>
        /// <value>
        /// Value from PatientProfile.AppointmentType property.
        /// </value>
        public AppointmentTypeCode AppointmentType { get; set; }

        /// <summary>
        ///     Get or Set EncounterTypeCode
        /// </summary>
        /// <value>
        /// Value from PatientProfile.EncounterTypeCode property.
        /// </value>
        public EncounterTypeCode EncounterTypeCode { get; set; }

        /// <summary>
        /// ConsultationStatus
        /// </summary>
        public int? ConsultationStatus { get; set; }

        /// <summary>
        /// PatientPaymentId
        /// </summary>
        public Guid? PatientPaymentId { get; set; }

        /// <summary>
        /// PatientPaymentUseCode
        /// </summary>
        public int? PatientPaymentUseCode { get; set; }

    }

    /// <summary>
    /// Represents Guardian  Information.
    /// </summary>
    public class Guardian
    {
        /// <summary>
        ///  Get or Set UserId
        /// </summary>
        /// <value>
        /// Value from Guardian.UserId property.
        /// </value>
        public int UserId { get; set; }

        /// <summary>
        ///  Get or Set Name
        /// </summary>
        /// <value>
        /// Value from Guardian.Name property.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        ///  Get or Set IsAuthorized
        /// </summary>
        /// <value>
        /// Value from Guardian.IsAuthorized property.
        /// </value>
        public bool IsAuthorized { get; set; }
    }
}
