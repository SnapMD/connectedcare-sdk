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
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the state (for postalcodes expansion).
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the states.
        /// </summary>
        /// <value>
        /// The states.
        /// </value>
        public List<string> States { get; set; }

        /// <summary>
        /// Gets or sets the counties (for postalcodes expansion).
        /// </summary>
        /// <value>
        /// The counties.
        /// </value>
        public List<string> Counties { get; set; }

        /// <summary>
        /// Gets or sets the cities (for postalcodes expansion).
        /// </summary>
        /// <value>
        /// The cities.
        /// </value>
        public List<string> Cities { get; set; }

        /// <summary>
        /// Gets or sets the postal codes.
        /// </summary>
        /// <value>
        /// The postal codes.
        /// </value>
        public List<string> PostalCodes { get; set; }
    }
}
