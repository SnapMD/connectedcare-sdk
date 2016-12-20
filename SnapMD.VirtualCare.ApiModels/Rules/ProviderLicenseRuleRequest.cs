using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for ProviderLicenseRule
    /// </summary>
    /// <seealso cref="RuleRequest" />
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

        /// <summary>
        /// Compare two regions for equality.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var second = obj as ProviderLicenseRegion;
            if (second == null)
                return false;
            return string.Equals(Country, second.Country, StringComparison.InvariantCultureIgnoreCase) &&
                   string.Equals(CountryCode, second.CountryCode, StringComparison.InvariantCultureIgnoreCase) &&
                   string.Equals(Region, second.Region, StringComparison.InvariantCultureIgnoreCase) &&
                   string.Equals(RegionCode, second.RegionCode, StringComparison.InvariantCultureIgnoreCase);
        }

        /// <summary>
        /// Create hash code according to new <see cref="Equals(object)"/> method.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return (Country     ?? string.Empty).ToLowerInvariant().GetHashCode() ^
                   (CountryCode ?? string.Empty).ToLowerInvariant().GetHashCode() ^
                   (Region      ?? string.Empty).ToLowerInvariant().GetHashCode() ^
                   (RegionCode  ?? string.Empty).ToLowerInvariant().GetHashCode();
        }
    }
}
