namespace SnapMD.ConnectedCare.ApiModels
{
    public class NewPatientProfileRequest
    {
        public string EmailAddress { get; set; }
        public string TimeZoneId { get; set; }
        public PatientProfileRequest PatientProfileData { get; set; }
        public PatientMedicalHistoryRequest PatientMedicalHistoryData { get; set; }
        public PatientProfileFieldsTracingRequest PatientProfileFieldsTracing { get; set; }
    }
}
