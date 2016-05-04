using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IPersonApi
    {
        ApiResponseV2<PersonRecord> GetPersonByEmail(string email, int? userType = null);

        ApiResponseV2<ClinicianPersonResponse> GetClinicianPerson(int providerId, int clinicianUserId);

        ApiResponseV2<PatientPersonResponse> GetPatientPerson(int providerId, int patientId);

    }
}
