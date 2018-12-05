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

using SnapMD.VirtualCare.ApiModels.Attributes;

namespace SnapMD.VirtualCare.ApiModels.Payments 
{
    /// 
    /// <summary>
    /// These models are for deserializing the responses from the Authorize.net API.
    /// </summary>
    [ModelName("ApiModels.PaymentProfile")]
    public class PaymentProfile {
        /// <summary>
        ///     Get or Set the patient  billing address.
        /// </summary>
        /// <value>
        ///    The patient full billing addres
        /// </value>
        public CimAddress BillingAddress { get; set; }
        /// <summary>
        ///     Get or Set the patient  id.
        /// </summary>
        /// <value>
        ///    The patient Id
        /// </value>
        public string ProfileID { get; set; }
        /// <summary>
        ///     Get or Set the bussiness status.
        /// </summary>
        /// <value>
        ///  The bussiness status
        /// </value>
        public bool IsBusiness { get; set; }
        /// <summary>
        ///     Get or Set the card number.
        /// </summary>
        /// <value>
        ///   Card Number
        /// </value>
        public string CardNumber { get; set; }
        /// <summary>
        ///     Get or Set the card type.
        /// </summary>
        /// <value>
        ///   Card type
        /// </value>
        public string CardType { get; set; }
        /// <summary>
        ///     Get or Set the card expiration.
        /// </summary>
        /// <value>
        ///  The card expiration
        /// </value>
        public string CardExpiration { get; set; }
        /// <summary>
        ///     Get or Set the Card Code.
        /// </summary>
        /// <value>
        ///  The Card Code
        /// </value>
        public string CardCode { get; set; }
    }

}