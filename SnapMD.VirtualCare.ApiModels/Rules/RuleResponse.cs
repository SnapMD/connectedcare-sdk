using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// The Interface Response of Rule.
    /// </summary>
    public interface IRuleResponse
    {
        /// <summary>
        /// The rule template identifier of the rule.
        /// A rule template define the logic of the rules.
        /// </summary>
        /// <value>
        /// The rule template.
        /// </value>
        RuleTemplateResponse RuleTemplate { get; set; }

        /// <summary>
        /// The version of the rule.
        /// Number of updates.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        int? Version { get; set; }

        /// <summary>
        /// The created datetime of the rule.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// The user identifier the rule created by.
        /// </summary>
        /// <value>
        /// The created by user identifier.
        /// </value>
        int CreatedByUserId { get; set; }

        /// <summary>
        /// The modified datetime of the rule.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// The user identifier the rule modified by.
        /// </summary>
        /// <value>
        /// The modified by user identifier.
        /// </value>
        int? ModifiedByUserId { get; set; }
    }

    /// <summary>
    /// Response model for Rule
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.IRuleResponse" />
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.RuleRequest" />
    public class RuleResponse : RuleRequest, IRuleResponse
    {
        /// <summary>
        /// The rule template of the rule.
        /// A rule template define the logic of the rules.
        /// </summary>
        /// <value>
        /// The rule template.
        /// </value>
        public RuleTemplateResponse RuleTemplate { get; set; }

        /// <summary>
        /// The rule details content in json.
        /// </summary>
        /// <value>
        /// The details json.
        /// </value>
        public string DetailsJson { get; set; }

        /// <summary>
        /// The version of the rule.
        /// Number of updates.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public int? Version { get; set; }

        /// <summary>
        /// The created datetime of the rule.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The user identifier the rule created by.
        /// </summary>
        /// <value>
        /// The created by user identifier.
        /// </value>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// The modified datetime of the rule.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// The user identifier the rule modified by.
        /// </summary>
        /// <value>
        /// The modified by user identifier.
        /// </value>
        public int? ModifiedByUserId { get; set; }
    }
}
