using System.ComponentModel;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Category of the Rules
    /// </summary>
    public enum RuleCategoryCode
    {
        /// <summary>
        /// The unknown type
        /// </summary>
        [Description("Undefined")]
        Unknown,

        /// <summary>
        /// The registration availability: Allow patients to register if
        /// </summary>
        [Description("Allow Patients to Register if")]
        RegistrationAvailability,

        /// <summary>
        /// The patient visibility: Patient can see providers if/where/when.
        /// </summary>
        [Description("Patient can see providers if/where/when")]
        PatientVisibility,

        /// <summary>
        /// The provider visibility: Provider can see patients if/where/when.
        /// </summary>
        [Description("Provider can see patients if/where/when")]
        ProviderVisibility,

        /// <summary>
        /// The provider visibility: Provider can see patients if/where/when.
        /// </summary>
        [Description("Visibility rule set")]
        VisibilityRuleSet,
    }

    /// <summary>
    /// Code for Type of Rules 
    /// </summary>
    public enum RuleTypeCode
    {
        /// <summary>
        /// The unknown, undefined rule
        /// </summary>
        Unknown,

        /// <summary>
        /// The address rule
        /// </summary>
        AddressRule,

        /// <summary>
        /// The distance rule
        /// </summary>
        DistanceRule,

        /// <summary>
        /// The patient organization rule
        /// </summary>
        PatientOrganizationRule,

        /// <summary>
        /// The rule that runs other rules
        /// </summary>
        CompoundRule,

        /// <summary>
        /// The provider license rule
        /// </summary>
        ProviderLicenseRule,

        /// <summary>
        /// The patient response rule
        /// </summary>
        PatientResponseRule,
    }

    /// <summary>
    /// Type of Rule Decisions
    /// </summary>
    public enum RuleDecisionTypeCode
    {
        /// <summary>
        /// No decision
        /// </summary>
        None,

        /// <summary>
        /// The yes
        /// </summary>
        Yes,

        /// <summary>
        /// The no
        /// </summary>
        No,

        /// <summary>
        /// The require
        /// </summary>
        Require,

        /// <summary>
        /// The redirect
        /// </summary>
        Redirect
    }

    /// <summary>
    /// Source of Rule Matching Condition
    /// </summary>
    public enum RuleConditionSource
    {
        /// <summary>
        /// No matching condition.
        /// </summary>
        None,

        /// <summary>
        /// The address data.
        /// </summary>
        Address,

        /// <summary>
        /// The distance data.
        /// </summary>
        Distance,

        /// <summary>
        /// The patient organization data.
        /// </summary>
        PatientOrganization,

        /// <summary>
        /// The patient organization + location data.
        /// </summary>
        PatientOrganizationLocation,

        /// <summary>
        /// The sub-rule data.
        /// </summary>
        SubRule,

        /// <summary>
        /// The provider license data.
        /// </summary>
        ProviderLicense,
    }

    /// <summary>
    /// Type of Rule Logic
    /// </summary>
    public enum RuleLogicTypeCode
    {
        /// <summary>
        /// The unknown type
        /// </summary>
        Unknown,

        /// <summary>
        /// Is the subject in criteria
        /// </summary>
        In,

        /// <summary>
        /// Is the subject not in criteria
        /// </summary>
        NotIn
    }

    /// <summary>
    /// Unit of Geo Distance
    /// </summary>
    public enum GeoDistanceUnit
    {
        /// <summary>
        /// The unkown unit
        /// </summary>
        Unkown,

        /// <summary>
        /// The nautical mile
        /// </summary>
        NauticalMile,

        /// <summary>
        /// The statute mile
        /// </summary>
        StatuteMile,

        /// <summary>
        /// The kilometer
        /// </summary>
        Kilometer
    }
}
