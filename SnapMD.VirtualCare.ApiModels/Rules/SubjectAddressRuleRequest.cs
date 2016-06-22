using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for SubjectAddressRule
    /// </summary>
    /// <seealso cref="RuleRequest" />
    public class SubjectAddressRuleRequest : RuleRequest
    {
        /// <summary>
        /// The list of subject addresses for creating or updating the rule.
        /// </summary>
        /// <value>
        /// The subject addresses.
        /// </value>
        public List<SubjectAddress> SubjectAddresses { get; set; }
    }

    /// <summary>
    /// SubjectAddress model.
    /// </summary>
    public class SubjectAddress
    {
        /// <summary>
        /// The country of the address.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// The country code of the address.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        public string CountryCode { get; set; }

        /// <summary>
        /// The state of the address.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// The state abbreviation code of the address.
        /// </summary>
        /// <value>
        /// The state code.
        /// </value>
        public string StateCode { get; set; }

        /// <summary>
        /// The city of the address.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// The postal code of the address.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string PostalCode { get; set; }
    }
}
