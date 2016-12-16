﻿using System;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Response model for PatientProviderLicenseRule.
    /// </summary>
    /// <seealso cref="IRuleResponse" />
    /// <seealso cref="PatientResponseRuleRequest" />
    public class PatientProviderLicenseRuleResponse : PatientProviderLicenseRuleRequest, IRuleResponse
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
