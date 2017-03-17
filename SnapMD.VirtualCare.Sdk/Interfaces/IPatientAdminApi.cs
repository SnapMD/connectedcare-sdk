using SnapMD.VirtualCare.ApiModels;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{

    public interface IPatientAdminApi
    {

        ApiResponse<PatientOnBoardShortDetail> GetPatient(string email);
        ApiResponseV2<AddPatientAdminResponseShort> AddPatient(PatientOnBoardShortDetailRequest patient);
        ApiResponseV2<AddPatientAdminResponseShort> AddPatient(PatientOnBoardShortDetailRequest patient, bool allowNullEmail);
        void DeletePatient(int patientId);
        ApiResponseV2<bool> UpdateDependentRelationAndAuthorization(int patientId, int dependentId, DependentRelationship requestData);

    }

}
