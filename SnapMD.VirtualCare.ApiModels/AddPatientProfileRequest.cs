using SnapMD.Web.Api.Models;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Request object adding a patient profile
    /// </summary>
    public class AddPatientProfileRequest
    {
        public string EmailAddress { get; set; }
        public PatientUpdateRequest PatientProfileData { get; set; }
        public LegacyMedicalHistoryForm PatientMedicalHistoryData { get; set; }
        public PatientProfileFieldChangesTrackingRequest PatientProfileFieldsTracing { get; set; }
        public int? TimeZoneId { get; set; }
    }

 
}