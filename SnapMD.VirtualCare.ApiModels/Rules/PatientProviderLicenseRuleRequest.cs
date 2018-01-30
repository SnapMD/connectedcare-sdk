using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for PatientProviderLicenseRule
    /// </summary>
    /// <seealso cref="RuleRequest" />
    [Obsolete("This class is not used in API calls anymore")]
    public class PatientProviderLicenseRuleRequest : RuleRequest
    {
        /// <summary>
        /// The directory of countries/regions used when editing provider's and patient's profiles 
        /// and other rule sources.
        /// This list is only present in metarule, rule instances use for comparison actual 
        /// countries/regions from their condition sources.
        /// </summary>
        /// <value>
        /// Countries/regions.
        /// </value>
        public List<CountryInfo> Countries { get; set; }
    }

    /// <summary>
    /// Country information: name, code and list of regions.
    /// </summary>
    public class CountryInfo
    {
        /// <summary>
        /// Full country name
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 2-3 letters country code (e.g. ISO 3166 code "US", "GB", "CN", "IN", "RU", ...)
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// List of country regions used in particular system installation
        /// </summary>
        public List<CountryRegionInfo> Regions { get; set; }
    }

    /// <summary>
    /// Country's region name and code
    /// </summary>
    public class CountryRegionInfo
    {
        /// <summary>
        /// Full region name
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Region code for particular country (e.g. ANSI state code for USA: "CA", "NY", "AK"...)
        /// </summary>
        public string RegionCode { get; set; }
    }
}
