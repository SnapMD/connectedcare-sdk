using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlocksRequest
    {
        public int[] ClinicianIds;
        public DateTime? StartDate;
        public DateTime? EndDate;
    }
}
