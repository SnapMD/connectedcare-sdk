namespace SnapMD.ConnectedCare.ApiModels
{

    /// <summary>
    /// The response returned when a call to MakePayment is made
    /// </summary>
    public struct CopayPaymentResponse
    {
        /// <summary>
        /// The confirmation # of the payment
        /// </summary>
        public string ConfirmationNumber { get; set; }
    }
}