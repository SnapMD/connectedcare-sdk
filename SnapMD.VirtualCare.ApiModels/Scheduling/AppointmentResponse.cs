using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Appointment response model.
    /// </summary>
    public class AppointmentResponse : AppointmentRequest
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
    }
}
