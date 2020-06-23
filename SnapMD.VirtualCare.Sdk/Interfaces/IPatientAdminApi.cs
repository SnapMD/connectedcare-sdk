using SnapMD.VirtualCare.ApiModels;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    /// <summary>
    /// Represent IPatient Admin Api.
    /// </summary>
    public interface IPatientAdminApi
    {
        /// <summary>
        ///   Get Patient.
        /// </summary>
        ///<param name="email"></param>
        /// <value>
        /// Return Patient On Board Short Detail.
        /// </value>
        ApiResponse<PatientOnBoardShortDetail> GetPatient(string email);

        /// <summary>
        ///   Add Patient.
        /// </summary>
        ///<param name="patient"></param>
        /// <value>
        /// Return Patient On Board Short Detail.
        /// </value>
        ApiResponseV2<AddPatientAdminResponseShort> AddPatient(PatientOnBoardShortDetailRequest patient);
        /// <summary>
        ///   Add Patient.
        /// </summary>
        ///<param name="patient"></param>
        ///<param name="allowNullEmail"></param>
        /// <value>
        /// Return Patient On Board Short Detail.
        /// </value>
        ApiResponseV2<AddPatientAdminResponseShort> AddPatient(PatientOnBoardShortDetailRequest patient, bool allowNullEmail);
        /// <summary>
        ///   Delete Patient.
        /// </summary>
        ///<param name="patientId"></param>
        void DeletePatient(int patientId);
        /// <summary>
        ///  Update Dependent Relation And Authorization.
        /// </summary>
        ///<param name="patientId"></param>
        ///<param name="dependentId"></param>
        ///<param name="requestData"></param>
        ApiResponseV2<bool> UpdateDependentRelationAndAuthorization(int patientId, int dependentId, DependentRelationship requestData);
        /// <summary>
        ///     Add dependent to patient family profile.
        ///     Works similar to HTTP POST 'v2/admin/patient/{patientId}/dependent', only requires relationship
        /// </summary>
        ApiResponseV2<PatientProfileResponse> AddDependentWithRelationForPatient(int patientId, AddDependentProfileRequest request, bool validateHardcoded = false, bool validateCustom = false);
        /// <summary>
        /// Sends or Resends Invitation to a CoUser.
        /// </summary>
        bool SendEmailInvitationToCoUser(CoUserEmailInvitationRequest request);
        /// <summary>
        /// Updates patient profile for current user.
        /// </summary>
        void UpdatePatient(AddPatientProfileRequest request);
    }

}
