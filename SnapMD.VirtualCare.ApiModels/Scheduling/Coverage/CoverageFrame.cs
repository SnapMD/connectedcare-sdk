using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling.Coverage
{
    /// <summary>
    /// Availability blocks coverage time frame with user ids.
    /// </summary>
    public class CoverageTimeFrame
    {
        /// <summary>
        /// Time from.
        /// </summary>
        public DateTimeOffset From { get; set; }

        /// <summary>
        /// Time to.
        /// </summary>
        public DateTimeOffset To { get; set; }

        /// <summary>
        /// Clinician user ids for time frame.
        /// </summary>
        public List<int> Clinicians { get; set; } 
    }
}
