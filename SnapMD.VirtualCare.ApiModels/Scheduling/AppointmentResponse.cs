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
        /// Was the appointment payed
        /// </summary>
        public bool Payed { get; set; }

        /// <summary>
        /// Payment amount
        /// </summary>
        public decimal? PaymentAmount { get; set; }

        /// <summary>
        /// Payment amount
        /// </summary>
        public string PaymentTransactionId { get; set; }

        /// <summary>
        /// Payment amount
        /// </summary>
        public bool? CreditUsed { get; set; }

        /// <summary>
        /// The latest flag (color mark) for appointment.
        /// </summary>
        public int? AppointmentFlag { get; set; }

        /// <summary>
        /// PatientQueueState
        /// </summary>
        public int? PatientQueueState { get; set; }

        /// <summary>
        /// If patient is connected to PatientQueue
        /// </summary>
        public bool? PatientQueueConnected { get; set; }

        /// <summary>
        /// Connection time of patient to the PatientQueue
        /// </summary>
        public DateTime? PatientQueueConnectionTime { get; set; }

        /// <summary>
        /// Connected userId of patientQueue
        /// </summary>
        public int? PatientQueueOwnerUserId { get; set; }

        /// <summary>
        /// PatientPaymentId
        /// </summary>
        public Guid? PatientPaymentId { get; set; }

        /// <summary>
        /// PatientPaymentUseCode
        /// </summary>
        public int? PatientPaymentUseCode { get; set; }

        /// <summary>
        /// Are there circumstances preventing the start of the consultation
        /// </summary>
        public int QueuingReadyState { get; set; }
    }
}
