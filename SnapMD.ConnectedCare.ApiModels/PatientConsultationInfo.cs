using System;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class PatientConsultationInfo
    {
        public int ConsultationId { get; set; }
        public int PatientId { get; set; }
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

        public string GuardianFirstName { get; set; }

        public string Guardianame
        {
            get { return string.Format("{0} {1}", GuardianFirstName, GuardianLastName); }
        }

        public string GuardianLastName { get; set; }
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
    }
}
