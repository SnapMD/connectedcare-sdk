﻿using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Response Model for OnDemandAvailability
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Scheduling.OnDemandAvailabilityRequest" />
    public class OnDemandAvailabilityResponse : OnDemandAvailabilityRequest
    {
        /// <summary>
        /// Gets or sets a value indicating whether [provider has ondemand enabled].
        /// </summary>
        /// <value>
        /// <c>true</c> if [provider has ondemand enabled]; otherwise, <c>false</c>.
        /// </value>
        public bool ProviderOnDemandEnabled { get; set; }

        /// <summary>
        /// The list of family members with <see cref="FamilyMember.ProviderAvailable"/> property set.
        /// </summary>
        public List<FamilyMember> FamilyMembers { get; set; }

        /// <summary>
        /// Start of current or next (if current does not available) availability block
        /// </summary>
        public DateTime? AvailabilityBlockStartTime { get; set; }

        /// <summary>
        /// Deprecated. Currently 1, if there exists available on demand provider right now, 0 - otherwise.
        /// </summary>
        [Obsolete("This field is no more calculated in API call")]
        public int OnDemandAvailabilityBlockCount { get; set; }
    }
}
