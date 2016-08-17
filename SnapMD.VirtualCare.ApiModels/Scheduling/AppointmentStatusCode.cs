namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Represents statuses of an <see cref="AppointmentApiRequest"/> or <seealso cref="AppointmentResponse"/> object.
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
        /// The event which the appointment represented has been initialized and the appointment is therefore fulfilled.
        /// </summary>
        Fulfilled,

        /// <summary>
        /// The patient was transferred to a different doctor.
        /// </summary>
        Transferred
    }
}
