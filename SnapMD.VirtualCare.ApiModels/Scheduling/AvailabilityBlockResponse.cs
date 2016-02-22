using System;
using System.Collections.Generic;

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
        public int Id { get; set; }

        /// <summary>
        /// Availability block clinicians.
        /// </summary>
        public IEnumerable<AvailabilityBlockClinicianResponse> AvailabilityBlockClinicians { get; set; }

        /// <summary>
        /// Rule should be set if block is repeating. Rule defines repeating configuration.
        /// </summary>
        public new AvailabilityBlockRuleResponse Rule { get; set; }

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
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Last modified date.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
    }
}
