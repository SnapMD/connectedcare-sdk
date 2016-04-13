using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for RuleTemplate
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.RuleRequestBase" />
    public class RuleTemplateRequest : RuleRequestBase
    {
        /// <summary>
        /// Gets or sets the rule set identifier.
        /// </summary>
        /// <value>
        /// The rule set identifier.
        /// </value>
        public Guid? RuleSetId { get; set; }

        /// <summary>
        /// Gets or sets the rule type identifier.
        /// </summary>
        /// <value>
        /// The rule type identifier.
        /// </value>
        public RuleTypeCode? RuleTypeId { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>
        /// The priority.
        /// </value>
        public int? Priority { get; set; }
    }
}
