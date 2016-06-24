using SnapMD.Web.Api.Models;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The API uses JSON camel case serialization, so the variables supplied in the incoming request will have lower case.
    /// </summary>
    public class AddPatientProfileRequest
    {
        public string EmailAddress { get; set; }
        public PatientUpdateRequest PatientProfileData { get; set; }
        public LegacyMedicalHistoryForm PatientMedicalHistoryData { get; set; }
        public PatientProfileFieldChangesTrackingRequest PatientProfileFieldsTracing { get; set; }
    }

 
}