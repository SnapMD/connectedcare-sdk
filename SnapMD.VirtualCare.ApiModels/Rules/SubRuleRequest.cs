using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for SubRule
    /// </summary>
    public class SubRuleRequest : RuleRequest
    {
        /// <summary>
        /// RuleType
        /// </summary>
        public RuleTypeCode RuleType { get; set; }
    }

    /// <summary>
    /// Request model for ProviderLicense subrule
    /// </summary>
    public class ProviderLicenseSubRuleRequest : SubRuleRequest
    {
        /// <summary>
        /// Provider license regions
        /// </summary>
        public List<ProviderLicenseRegion> ProviderLicenseRegions { get; set; }
    }

    /// <summary>
    /// Request model for SubjectArea subrule
    /// </summary>
    public class SubjectAreaSubRuleRequest : SubRuleRequest
    {
        /// <summary>
        /// Patient's address
        /// </summary>
        public List<SubjectAddress> SubjectAddresses { get; set; }
    }

    /// <summary>
    /// CompoundRule
    /// </summary>
    public class CompoundRuleRequest : RuleRequest
    {
        /// <summary>
        /// List of SubRules
        /// </summary>
        public List<SubRuleRequest> SubRules { get; set; }
    }
}
