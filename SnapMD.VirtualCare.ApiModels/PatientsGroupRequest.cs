namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Body parameters for many patients groups methods API.
    /// </summary>
    /// <remarks>
    /// Depending of the API method, only a part of field set can be used.
    /// </remarks>
    public class PatientsGroupRequest
    {
        /// <summary>
        /// Ids of patients method operates on.
        /// </summary>
        public int[] PatientsIds { get; set; }

        /// <summary>
        /// Id of group method operates on.
        /// </summary>
        /// <remarks>In most methods group id could be passed either in this parameter or in <see cref="PatientsGroupRequest.GroupsIds"/></remarks>
        public int? GroupId { get; set; }

        /// <summary>
        /// Ids of groups method operates on.
        /// </summary>
        /// <remarks>In most methods group id could be passed either in this parameter or in <see cref="PatientsGroupRequest.GroupId"/></remarks>
        public int[] GroupsIds { get; set; }

        /// <summary>
        /// Name of the group
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the group
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Status of the group
        /// </summary>
        public GlobalStatusCode? StatusCode { get; set; }

        /// <summary>
        /// Id of the parent group in the hierarchy
        /// </summary>
        public int? ParentGroupId { get; set; }
    }
}
