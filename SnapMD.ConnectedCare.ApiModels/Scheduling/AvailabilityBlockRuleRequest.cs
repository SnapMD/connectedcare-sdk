using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlockRuleRequest
    {
        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public int[] RepeatOn { get; set; }

        public int RepeatInterval { get; set; }

        public int RepeatPeriod { get; set; }
    }
}
