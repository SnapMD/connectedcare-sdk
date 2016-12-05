using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// 
    /// </summary>
    public class CompoundRuleResponse : CompoundRuleRequest, IRuleResponse
    {
        /// <summary>
        /// The rule template of the rule.
        /// A rule template defines the logic of the rules.
        /// </summary>
        /// <value>
        /// The rule template.
        /// </value>        
        public RuleTemplateResponse RuleTemplate { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        public int? Version { get; set; }

        /// <summary>
        /// CreateDate
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// CreatedByUserId
        /// </summary>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// ModifiedDate
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// ModifiedByUserId
        /// </summary>
        public int? ModifiedByUserId { get; set; }
    }
}
