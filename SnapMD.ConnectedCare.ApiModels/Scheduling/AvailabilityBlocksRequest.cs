using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlocksRequest
    {
        public int HospitalId { get; set; }

        public bool SearchByGroups { get; set; }

        public int[] ClinicianIds { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}
