using System;
namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Providers group description returned from  API.
    /// </summary>
    /// <remarks>
    /// Depending of the API method, only a part of field set can be used.
    /// </remarks>
    public class ClinicianGroupResponse: ClinicianGroupRequest
    {
        /// <summary>
        /// Id of the Clinicial 
        /// </summary>
        public int? ClinicianId { get; set; }

        /// <summary>
        /// Id of the hospital holding the group
        /// </summary>
        public int? HospitalId { get; set; }

        /// <summary>
        /// The time when the group was modified lately.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// List of subgroups. May not be used for some API methods.
        /// </summary>
        public ClinicianGroupResponse[] SubGroups { get; set; }

        /// <summary>
        /// Providers assigned to this group. May not be used for some API methods.
        /// </summary>
        public ClinicianProfilesResult[] Members { get; set; }
    }
}
