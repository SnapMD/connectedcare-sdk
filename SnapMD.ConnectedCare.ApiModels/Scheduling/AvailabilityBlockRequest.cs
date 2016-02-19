using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    /// <summary>
    ///     This payload does not include ID field, creator user, created time, etc.
    /// </summary>
    public class AvailabilityBlockRequest
    {
        public DateTime? EndTime { get; set; }
        public DateTime? StartTime { get; set; }

        public bool AllowOnDemandAppt { get; set; }
        public bool AllowProviderAppt { get; set; }
        public bool AllowSelfAppt { get; set; }
        public bool IsAllDay { get; set; }
        public bool IsAvailable { get; set; }

        public int? AvailabilityBlockRuleId { get; set; }

        public AppointmentOptimizationCode OptimizationTypeCode { get; set; }
    }
}
