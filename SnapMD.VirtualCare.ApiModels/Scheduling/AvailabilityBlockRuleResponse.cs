using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    public class AvailabilityBlockRuleResponse : AvailabilityBlockRuleRequest
    {
        public Guid Id { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
