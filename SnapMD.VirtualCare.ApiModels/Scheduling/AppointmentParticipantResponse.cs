using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    ///     Request type for appointment participants.
    /// </summary>
    public class AppointmentParticipantResponse : AppointmentParticipantRequest
    {
        /// <summary>
        /// Gets or sets the participant identifier.
        /// </summary>
        /// <value>
        /// The participant identifier.
        /// </value>
        public Guid ParticipantId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public virtual GlobalStatusCode Status { get; set; }
    }
}
