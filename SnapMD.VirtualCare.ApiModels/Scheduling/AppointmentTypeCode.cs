namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Types of appointments.
    /// </summary>
    public enum AppointmentTypeCode
    {
        /// <summary>
        /// Not specified.
        /// </summary>
        None,

        /// <summary>
        /// Clinician scheduled.
        /// </summary>
        ClinicianScheduled,

        /// <summary>
        /// Appointments on-demand.
        /// </summary>
        OnDemand,

        /// <summary>
        /// Patient self-scheduled.
        /// </summary>
        PatientScheduled
    }
}
