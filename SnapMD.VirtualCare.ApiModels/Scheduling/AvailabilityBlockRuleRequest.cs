using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Availability block rule defines availability blocks repeating configuration.
    /// </summary>
    public class AvailabilityBlockRuleRequest
    {
        /// <summary>
        /// Repeat from.
        /// </summary>
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Repeat to.
        /// </summary>
        public DateTime? ToDate { get; set; }

        /// <summary>
        /// Create availability blocks every {repeat interval} {repeat period}.
        /// </summary>
        public int RepeatInterval { get; set; }

        /// <summary>
        /// For monthly rule - days of a month, for weekly rules - days of the week.
        /// </summary>
        public int[] RepeatOn { get; set; }

        /// <summary>
        /// Repeat daily/weekly/monthly.
        /// </summary>
        public RepeatPeriodCode RepeatPeriod { get; set; }
    }
}
