using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    public class AvailabilityBlockClinicianRequest
    {
        public Guid AvailabilityBlockId { get; set; }
        public int ClinicianId { get; set; }
        public bool Locked { get; set; }
        public bool Private { get; set; }
    }
}
