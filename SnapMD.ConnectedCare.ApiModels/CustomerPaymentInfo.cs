
using System.Collections.Generic;

namespace SnapMD.ConnectedCare.ApiModels
{
    /// <summary>
    /// Corresponds to customer payment irrespective of payment gateway provider
    /// </summary>
    public class CustomerPaymentInfo
    {
        public string BillingAddress { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }

        public string ID { get; set; }
        public string ProfileID { get; set; }
        public IList<string> ShippingAddresses { get; set; }

        public string CardNumber { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
    }
}
