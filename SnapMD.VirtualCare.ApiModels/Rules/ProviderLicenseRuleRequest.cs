using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for ProviderLicenseRule
    /// </summary>
    /// <seealso cref="RuleRequest" />
    [Obsolete("This class is not used in API calls anymore")]
    public class ProviderLicenseRuleRequest : RuleRequest
    {
        /// <summary>
        /// The list of countries/regions for creating or updating the rule.
        /// </summary>
        /// <value>
        /// Countries/states.
        /// </value>
        public List<ProviderLicenseRegion> ProviderLicenseRegions { get; set; }
    }

    /// <summary>
    /// SubjectAddress model.
    /// </summary>
    [Obsolete("This class is not used in API calls anymore")]
    public class ProviderLicenseRegion
    {
        /// <summary>
        /// The country of the state/province.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Country { get; set; }

        /// <summary>
        /// The country code.
        /// </summary>
        /// <value>
        /// The country code.
        /// </value>
        public string CountryCode { get; set; }

        /// <summary>
        /// The state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string Region { get; set; }

        /// <summary>
        /// The state abbreviation code.
        /// </summary>
        /// <value>
        /// The state code.
        /// </value>
        public string RegionCode { get; set; }
    }
}
