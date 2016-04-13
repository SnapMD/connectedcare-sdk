namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Represents statuses of an <see cref="AppointmentRequest"/> or <seealso cref="AppointmentResponse"/> object.
    /// </summary>
    public enum AppointmentStatusCode
    {
        /// <summary>
        /// The variable has not been initialized.
        /// </summary>
        NotSpecified,

        /// <summary>
        /// A future appointment.
        /// </summary>
        Scheduled,

        /// <summary>
        /// The patient for this appointment arrived to the clinic.
        /// </summary>
        Waiting,

        /// <summary>
        /// The patient cancelled the appointment.
        /// </summary>
        CancelledByPatient,

        /// <summary>
        /// The appointment was cancelled by the Provider.
        /// </summary>
        CancelledByProvider,

        /// <summary>
        /// The appointment is currently taking place.
        /// </summary>
        InProgress,

        /// <summary>
        /// The patient was transferred to a different doctor.
        /// </summary>
        Transferred
    }
}
