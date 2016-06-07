using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for SubjectAddressRule
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.RuleRequest" />
    public class SubjectAddressRuleRequest : RuleRequest
    {
        /// <summary>
        /// Gets or sets the subject addresses.
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
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        /// <value>
        /// The city.
        /// </value>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        public string PostalCode { get; set; }
    }
}
