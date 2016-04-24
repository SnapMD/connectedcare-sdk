using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    ///     Request type for appointment participants.
    /// </summary>
    public class AppointmentParticipantResponse : AppointmentParticipantRequest
    {
        /// <summary>
        ///     Participant id.
        /// </summary>
        public Guid ParticipantId { get; set; }

        /// <summary>
        ///     Participant status.
        /// </summary>
        public virtual GlobalStatusCode Status { get; set; }
    }
}
