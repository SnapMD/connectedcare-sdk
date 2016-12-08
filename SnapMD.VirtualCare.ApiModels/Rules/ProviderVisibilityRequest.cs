using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for provider visibility
    /// </summary>
    public class ProviderVisibilityRequest : IRuleExecutionRequest
    {
        /// <summary>
        /// The category of the rule for the request.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public RuleCategoryCode Category => RuleCategoryCode.ProviderVisibility;

        /// <summary>
        /// The hospital identifier for filtering the rules.
        /// </summary>
        /// <value>
        /// The hospital identifier.
        /// </value>
        public int HospitalId { get; set; }

        /// <summary>
        /// Address from patient response
        /// </summary>
        /// <value>
        /// Country/state/city/postal code.
        /// </value>
        public SubjectAddress PatientResponseAddress { get; set; }

        /// <summary>
        /// A value indicating whether this is debug.
        /// (inhetrited from <see cref="IRuleExecutionRequest"/>).
        /// Additional information maybe included in the response on debug.
        /// </summary>
        /// <value>
        ///   <c>true</c> if debug; otherwise, <c>false</c>.
        /// </value>
        public bool? Debug { get; set; }
    }
}
