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
        /// The rule set identifier of the rule template.
        /// </summary>
        /// <value>
        /// The rule set identifier.
        /// </value>
        public Guid? RuleSetId { get; set; }

        /// <summary>
        /// The rule type identifier of the rule template.
        /// </summary>
        /// <value>
        /// The rule type identifier.
        /// </value>
        public RuleTypeCode? RuleTypeId { get; set; }

        /// <summary>
        /// The priority of rule tempates.
        /// </summary>
        /// <value>
        /// The priority.
        /// </value>
        public int? Priority { get; set; }

        /// <summary>
        /// The image path of the rule template.
        /// </summary>
        /// <value>
        /// The image path.
        /// </value>
        public string ImagePath { get; set; }
    }
}
