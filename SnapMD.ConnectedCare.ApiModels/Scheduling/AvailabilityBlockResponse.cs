using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlockResponse : AvailabilityBlockRequest
    {
        public int CreatedByUserId { get; set; }

        public DateTime CreatedDate { get; set; }

        public int Id { get; set; }

        public int? ModifiedByUserId { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public AvailabilityBlockRuleResponse Rule { get; set; }
    }
}
