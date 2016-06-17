namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for Generic Rules.
    /// </summary>
    /// <seealso cref="RuleRequest" />
    public class RuleDetailsRequest : RuleRequest
    {
        /// <summary>
        /// The rule details content in json.
        /// </summary>
        /// <value>
        /// The details json.
        /// </value>
        public string DetailsJson { get; set; }
    }
}
