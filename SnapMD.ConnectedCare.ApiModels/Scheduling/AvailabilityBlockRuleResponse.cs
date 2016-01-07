using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlockRuleResponse : AvailabilityBlockRuleRequest
    {
        public DateTime? ModifiedDate { get; set; }
    }
}
