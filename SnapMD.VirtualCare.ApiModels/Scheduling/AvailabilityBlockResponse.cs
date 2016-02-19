using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    public class AvailabilityBlockResponse : AvailabilityBlockRequest
    {
        public Guid Id { get; set; }

        public AvailabilityBlockRuleResponse Rule { get; set; }
        public IEnumerable<AvailabilityBlockClinicianResponse> AvailabilityBlockClinicians { get; set; }

        public int CreatedByUserId { get; set; }
        public int? ModifiedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
