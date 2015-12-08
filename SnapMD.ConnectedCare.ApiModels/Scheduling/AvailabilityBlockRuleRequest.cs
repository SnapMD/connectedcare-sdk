using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlockRuleRequest
    {
        public DateTime FromDate { get; set; }

        public int[] RepeatOn { get; set; }
    }
}
