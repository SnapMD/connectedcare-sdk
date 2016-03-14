using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    public class AvailabilityBlocksRequest
    {
        public int ProviderId { get; set; }
        
        public int[] ClinicianIds { get; set; }

        public Guid[] Groups { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
