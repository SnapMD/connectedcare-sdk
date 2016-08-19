using System;

namespace SnapMD.VirtualCare.ApiModels.Payments
{
    /// <summary>
    /// Request Model for PatientPayment API
    /// </summary>
    public class PatientPaymentRequest
    {
        /// <summary>
        /// The patient payment identifier.
        /// </summary>
        public Guid? PatientPaymentId { get; set; }

        /// <summary>
        /// The credit amount.
        /// </summary>
        public decimal? CreditAmount { get; set; }

        /// <summary>
        /// The debit amount.
        /// </summary>
        public decimal? DebitAmount { get; set; }

        /// <summary>
        /// The consultation identifier to associated with the payment.
        /// </summary>
        public int? ConsultationId { get; set; }
    }
}
