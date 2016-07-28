using System;
using SnapMD.VirtualCare.ApiModels.Scheduling;

namespace SnapMD.VirtualCare.ApiModels.Payments
{
    /// <summary>
    /// Response Model for PatientPaymentRequest
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Payments.PatientPaymentRequest" />
    public class PatientPaymentResponse : PatientPaymentRequest
    {
        /// <summary>
        /// Gets or sets the patient identifier.
        /// </summary>
        /// <value>
        /// The patient identifier.
        /// </value>
        public int PatientId { get; set; }

        /// <summary>
        /// The credit date.
        /// </summary>
        public DateTime CreditDate { get; set; }

        /// <summary>
        /// The debit date.
        /// </summary>
        public DateTime? DebitDate { get; set; }

        /// <summary>
        /// The appointment type code.
        /// </summary>
        public AppointmentTypeCode AppointmentTypeCode { get; set; }
    }
}
