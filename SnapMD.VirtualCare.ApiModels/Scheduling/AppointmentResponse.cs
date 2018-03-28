using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Appointment response model.
    /// </summary>
    public class AppointmentResponse : AppointmentApiRequest
    {
        /// <summary>
        /// Appointment id.
        /// </summary>
        public Guid AppointmentId { get; set; }

        /// <summary>
        /// Patient identifier who appointment is for
        /// </summary>
        public int? PatientId { get; set; }

        /// <summary>
        /// Clinician identifier
        /// </summary>
        public int? ClinicianId { get; set; }

        /// <summary>
        /// Appointment status.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AppointmentStatusCode AppointmentStatusCode { get; set; }

        /// <summary>
        /// Gets or sets the participants.
        /// </summary>
        /// <value>
        /// The participants.
        /// </value>
        public new List<AppointmentParticipantResponse> Participants { get; set; }

        /// <summary>
        /// Gets or sets the consultation identifier.
        /// </summary>
        /// <value>
        /// The consultation identifier.
        /// </value>
        public int? ConsultationId { get; set; }

        /// <summary>
        /// ProxyUserId from consultation (if exists).
        /// </summary>
        public int? ProxyUserId { get; set; }

        /// <summary>
        /// Whether the appointment is dismissed
        /// </summary>
        public bool Dismissed { get; set; }

        /// <summary>
        /// Dismissal reason, null if wasn't dismissed
        /// </summary>
        public string DismissedReason { get; set; }

        /// <summary>
        /// Service type name
        /// </summary>
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// The latest flag (color mark) for appointment.
        /// </summary>
        public int? AppointmentFlag { get; set; }
    }
}
