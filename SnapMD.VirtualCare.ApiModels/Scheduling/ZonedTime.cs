using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Represents a time interval in an explicitly set timezone
    /// </summary>
    public class ZonedTime
    {
        /// <summary>
        /// Timezone ID from timezone API
        /// </summary>
        public int TimeZoneId { get; set; }

        /// <summary>
        /// The interval start time
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The interval end time
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}