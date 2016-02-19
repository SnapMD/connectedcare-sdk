using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlockRuleRequest
    {
        public int Id { get; set; }

        public byte StartTimeHour { get; set; }
        public byte StartTimeMinute { get; set; }
        public byte EndTimeHour { get; set; }
        public byte EndTimeMinute { get; set; }

        public DateTime FromDate { get; set; }
        public DateTime? ToDate { get; set; }

        public int RepeatInterval { get; set; }
        public int[] RepeatOn { get; set; }
        public RepeatPeriodCode RepeatPeriod { get; set; }

        public bool AllowOnDemandAppt { get; set; }
        public bool AllowProviderAppt { get; set; }
        public bool AllowSelfAppt { get; set; }
        public bool IsAllDay { get; set; }
    }
}
