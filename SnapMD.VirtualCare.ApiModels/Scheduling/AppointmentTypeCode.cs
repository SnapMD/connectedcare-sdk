namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Types of appointments.
    /// </summary>
    public enum AppointmentTypeCode
    {
        /// <summary>
        /// Not specified
        /// </summary>
        None,

        /// <summary>
        /// Future appointment
        /// </summary>
        Future,

        /// <summary>
        /// Appointments on-demand
        /// </summary>
        OnDemand
    }
}
