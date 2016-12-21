using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for PatientResponseRule
    /// </summary>
    /// <seealso cref="RuleRequest" />
    public class PatientResponseRuleRequest : RuleRequest
    {
        /// <summary>
        /// The list of addresses for creating or updating the rule.
        /// </summary>
        /// <value>
        /// Countries/states/cities/postal codes.
        /// </value>
        public List<SubjectAddress> PatientResponseAddresses { get; set; }
    }
}
