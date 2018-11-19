using SnapMD.VirtualCare.ApiModels;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    /// <summary>
    /// Return person api.
    /// </summary>
    public interface IStaffApi
    {
        /// <summary>
        /// Creates a new staff profile with the parameters passed in request
        /// </summary>
        /// <param name="request">Request to create the new staff profile</param>
        /// <returns></returns>
        ApiResponseV2<CreateStaffProfileResponse> NewStaffProfile(StaffAccountModelRequest request);
    }
}
