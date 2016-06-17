using System;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Response model for RuleTemplate
    /// </summary>
    /// <seealso cref="RuleTemplateRequest" />
    public class RuleTemplateResponse : RuleTemplateRequest
    {
        /// <summary>
        /// The rule set the rule template belongs to.
        /// </summary>
        /// <value>
        /// The rule set.
        /// </value>
        public RuleSetResponse RuleSet { get; set; }

        /// <summary>
        /// The created datetime of the rule template.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The user identifier of the rule template created by.
        /// </summary>
        /// <value>
        /// The created by user identifier.
        /// </value>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// The modified date of the rule template.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// The user identifier of the rule template modified by.
        /// </summary>
        /// <value>
        /// The modified by user identifier.
        /// </value>
        public int? ModifiedByUserId { get; set; }
    }
}
