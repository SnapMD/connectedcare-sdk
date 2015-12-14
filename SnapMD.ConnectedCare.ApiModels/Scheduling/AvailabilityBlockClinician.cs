namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlockClinician
    {
        public int AvailabilityBlockId { get; set; }
        public int ClinicianId { get; set; }
        public bool Locked { get; set; }
        public bool Private { get; set; }
    }
}
