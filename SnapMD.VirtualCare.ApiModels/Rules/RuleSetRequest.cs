using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for RuleSet
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.RuleRequestBase" />
    public class RuleSetRequest : RuleRequestBase
    {
        /// <summary>
        /// The rule category identifier of the rule set.
        /// </summary>
        /// <value>
        /// The rule category identifier.
        /// </value>
        public RuleCategoryCode? RuleCategoryId { get; set; }
    }
}
