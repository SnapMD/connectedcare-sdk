namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request Model for PatientOrganizationRule
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.RuleRequest" />
    public class PatientOrganizationRuleRequest : RuleRequest
    {
        /// <summary>
        /// The organization identifier to evaluated.
        /// </summary>
        /// <value>
        /// The organization identifier.
        /// </value>
        public int? OrganizationId { get; set; }

        /// <summary>
        /// The location identifier to be evaluated.
        /// </summary>
        /// <value>
        /// The location identifier.
        /// </value>
        public int? LocationId { get; set; }
    }
}
