﻿using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Request model for AvailabilityBlocks search filter
    /// </summary>
    public class AvailabilityBlocksFilter
    {
        /// <summary>
        /// Gets or sets the clinician ids.
        /// </summary>
        /// <value>
        /// The clinician ids.
        /// </value>
        public int[] ClinicianIds { get; set; }

        /// <summary>
        /// Caregivers user ids for filtering.
        /// </summary>
        public int[] CaregiversIds { get; set; }

        /// <summary>
        /// Gets or sets the groups.
        /// </summary>
        /// <value>
        /// The groups.
        /// </value>
        public Guid[] Groups { get; set; }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime? EndDate { get; set; }
    }
}
