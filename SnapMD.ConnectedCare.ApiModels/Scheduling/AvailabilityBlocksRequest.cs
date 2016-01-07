using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlocksRequest
    {
        public int[] ClinicianIds { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
