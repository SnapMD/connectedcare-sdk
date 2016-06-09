namespace SnapMD.VirtualCare.ApiModels.Scheduling.Coverage
{
    /// <summary>
    /// Type of availability blocks coverage.
    /// </summary>
    public enum CoverageType
    {
        /// <summary>
        /// On demand blocks.
        /// </summary>
        OnDemand = 0,

        /// <summary>
        /// Patient scheduled blocks.
        /// </summary>
        PatientScheduled = 1,

        /// <summary>
        /// Clinician scheduled blocks.
        /// </summary>
        AdminScheduled = 2,

        /// <summary>
        /// Unavailable.
        /// </summary>
        Unavailable = 3
    }
}
