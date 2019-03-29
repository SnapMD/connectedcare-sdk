using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    /// <summary>
    /// Return person api.
    /// </summary>
    public interface IPersonApi
    {
        /// <summary>
        /// Get person by api
        /// </summary>
        ApiResponseV2<PersonRecord> GetPersonByEmail(string email, int? userType = null);

        /// <summary>
        /// Get clinician person
        /// </summary>
        ApiResponseV2<ClinicianPersonResponse> GetClinicianPerson(int providerId, int clinicianUserId);
        /// <summary>
        /// Get patient
        /// </summary>
        ApiResponseV2<PatientPersonResponse> GetPatientPerson(int providerId, int patientId);

    }
}
