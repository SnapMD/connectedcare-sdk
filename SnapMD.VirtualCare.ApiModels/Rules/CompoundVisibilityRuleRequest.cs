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
    [Obsolete("This class is not used in API calls anymore")]
    public class SubRuleRequest : RuleRequest
    {
        /// <summary>
        /// RuleType
        /// </summary>
        public RuleTypeCode RuleType { get; set; }
    }

    /// <summary>
    /// CompoundRule
    /// </summary>
    [Obsolete("This class is not used in API calls anymore")]
    public class CompoundVisibilityRuleRequest : RuleRequest
    {
        /// <summary>
        /// List of SubRules
        /// </summary>
        public List<RuleRequest> SubRules { get; set; }
    }
}
