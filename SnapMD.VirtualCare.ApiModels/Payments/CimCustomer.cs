#region Copyright

//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

#endregion

using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Payments
{
    /// <summary>
    ///     These models are for deserializing the responses from the Authorize.net API.
    /// </summary>
    public class CimCustomer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CimCustomer" /> class.
        /// </summary>
        public CimCustomer()
        {
            ID = "MerchantCustomerID";
            ShippingAddresses = new List<CimAddress>();
            PaymentProfiles = new List<PaymentProfile>();
        }

        /// <summary>
        ///     Gets or sets the billing address.
        /// </summary>
        /// <value>
        ///     The billing address.
        /// </value>
        public CimAddress BillingAddress { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        /// <value>
        ///     The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the email.
        /// </summary>
        /// <value>
        ///     The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public string ID { get; set; }

        /// <summary>
        ///     Gets or sets the payment profiles.
        /// </summary>
        /// <value>
        ///     The payment profiles.
        /// </value>
        public IList<PaymentProfile> PaymentProfiles { get; set; }

        /// <summary>
        ///     Gets or sets the customer billing profile identifier.
        /// </summary>
        /// <value>
        ///     The profile identifier.
        /// </value>
        public string ProfileID { get; set; }

        /// <summary>
        ///     Gets or sets the shipping addresses.
        /// </summary>
        /// <value>
        ///     The shipping addresses.
        /// </value>
        public IList<CimAddress> ShippingAddresses { get; set; }

        /// <summary>
        ///     Gets or sets the payment systems.
        /// </summary>
        /// <value>
        ///     The payment profiles.
        /// </value>
        public IList<PaymentSystem> PaymentSystems { get; set; }
    }
}
