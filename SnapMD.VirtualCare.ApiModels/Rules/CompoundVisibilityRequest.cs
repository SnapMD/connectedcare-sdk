using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for provider-patient visibility rules
    /// </summary>
    [Obsolete("This class is not used in API calls anymore")]
    public class CompoundVisibilityRequest : IRuleExecutionRequest
    {
        /// <summary>
        /// The category of the rule for the request.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        public RuleCategoryCode Category => RuleCategoryCode.VisibilityRuleSet;

        /// <summary>
        /// The hospital identifier for filtering the rules.
        /// </summary>
        /// <value>
        /// The hospital identifier.
        /// </value>
        public int HospitalId { get; set; }

        /// <summary>
        /// Provider's license countries/regions
        /// </summary>
        /// <value>
        /// The address text.
        /// </value>
        public List<ProviderLicenseRegion> ProviderLicenseRegions { get; set; }

        /// <summary>
        /// Parsed patient address from patient's profile
        /// </summary>
        /// <value>
        /// Country/state/city/postal code.
        /// </value>
        public SubjectAddress PatientAddress { get; set; }

        /// <summary>
        /// Unarsed patient address from patient's profile
        /// </summary>
        /// <value>
        /// Free-form address text.
        /// </value>
        public string PatientAddressText { get; set; }

        /// <summary>
        /// Parsed  encounter address from patient's response
        /// </summary>
        /// <value>
        /// Country/state/city/postal code.
        /// </value>
        public SubjectAddress EncounterAddress { get; set; }

        /// <summary>
        /// Unarsed encounter address from patient's response
        /// </summary>
        /// <value>
        /// Free-form address text.
        /// </value>
        public string EncounterAddressText { get; set; }

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
