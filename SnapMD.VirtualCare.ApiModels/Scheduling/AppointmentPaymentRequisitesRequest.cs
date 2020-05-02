namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Health plan, credit card and other info which may be used to prefill consultation creation forms.
    /// </summary>
    public class AppointmentPaymentRequisitesRequest
    {
        /// <summary>
        /// ID of the health plan or null if health plan should not be applied.
        /// </summary>
        public int? HealthPlanId { get; set; }

        private string _insuranceCompany;
        /// <summary>
        /// Insurance company name for <see cref="HealthPlanId"/>
        /// </summary>
        public string InsuranceCompany
        {
            get => HealthPlanId == -2 ? "Default insurance plan" : _insuranceCompany;
            set => _insuranceCompany = value;
        }

        /// <summary>
        /// The Customer Profile ID returned from v2/patients/payments.
        /// </summary>
        public string CimProfileId { get; set; }

        /// <summary>
        /// The Payment Profile ID corresponding to the card the patient wishes to use for the transaction.
        /// </summary>
        public string PaymentProfileId { get; set; }

        /// <summary>
        /// Consultation cost as was calculated during appointment creation. Real cost may differ.
        /// </summary>
        public double? ConsultationAmount { get; set; }

        /// <summary>
        /// Amount of consultation cost covered by insurance as was calculated during appointment creation. Real amount may differ.
        /// </summary>
        public double? CopayAmount { get; set; }

        /// <summary>
        /// A code string of the coupon that needs to be applied to the payment.
        /// </summary>
        public string CouponCode { get; set; }

        public string Type { get; set; }

    }
}