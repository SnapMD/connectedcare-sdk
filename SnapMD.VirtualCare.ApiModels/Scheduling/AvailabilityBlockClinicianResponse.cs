using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Represents availability block clinician response.
    /// </summary>
    public class AvailabilityBlockClinicianResponse : AvailabilityBlockClinicianRequest
    {
        /// <summary>
        /// Clinician availability block id.
        /// </summary>
        public Guid AvailabilityBlockId { get; set; }

        /// <summary>
        /// Created by user id.
        /// </summary>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// Modified by user id.
        /// </summary>
        public int? ModifiedByUserId { get; set; }

        /// <summary>
        /// Created date.
        /// </summary>
        public DateTimeOffset CreatedDate { get; set; }

        /// <summary>
        /// Last modified date.
        /// </summary>
        public DateTimeOffset? ModifiedDate { get; set; }
    }
}
