using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Availability block response model.
    /// </summary>
    public class AvailabilityBlockResponse : AvailabilityBlockRequest
    {
        /// <summary>
        /// Availability block id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Rule should be set if block is repeating. Rule defines repeating configuration.
        /// </summary>
        public new AvailabilityBlockRuleResponse Rule { get; set; }

        /// <summary>
        /// Availability block clinician.
        /// </summary>
        public new AvailabilityBlockClinicianResponse Clinician { get; set; }

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
        
        /// <summary>
        /// Modified by user name.
        /// </summary>
        public string ModifiedByUserName { get; set; }
    }
}
