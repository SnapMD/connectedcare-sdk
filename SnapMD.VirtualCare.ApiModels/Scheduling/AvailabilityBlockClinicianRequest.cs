namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Represents availability block clinician request.
    /// </summary>
    public class AvailabilityBlockClinicianRequest
    {
        /// <summary>
        /// Clinician id.
        /// </summary>
        public int ClinicianId { get; set; }

        /// <summary>
        /// Is locked.
        /// </summary>
        public bool Locked { get; set; }

        /// <summary>
        /// Is private.
        /// </summary>
        public bool Private { get; set; }
    }
}
