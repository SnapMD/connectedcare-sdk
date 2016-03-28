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
        Unknown,

        /// <summary>
        /// The registration availability: Allow patients to register if
        /// </summary>
        RegistrationAvailability,

        /// <summary>
        /// The patient visibility: Patient can see providers if/where/when.
        /// </summary>
        PatientVisibility,

        /// <summary>
        /// The provider visibility: Provider can see patients if/where/when.
        /// </summary>
        ProviderVisibility
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
        /// The allow
        /// </summary>
        Allow,

        /// <summary>
        /// The disallow
        /// </summary>
        Disallow,

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
        /// The unknown source
        /// </summary>
        Unknown,

        /// <summary>
        /// The address country
        /// </summary>
        AddressCountry,

        /// <summary>
        /// The address country + state
        /// </summary>
        AddressState,

        /// <summary>
        /// The address country + state + postal code
        /// </summary>
        AddressPostalCode,

        /// <summary>
        /// The distance
        /// </summary>
        Distance,

        /// <summary>
        /// The patient organization
        /// </summary>
        PatientOrganization,

        /// <summary>
        /// The patient organization + location
        /// </summary>
        PatientOrganizationLocation
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
