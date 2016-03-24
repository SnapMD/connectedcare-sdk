namespace SnapMD.VirtualCare.ApiModels.PermissionRules
{
    /// <summary>
    /// Category of PermissionRule
    /// </summary>
    public enum PermissionRuleCategory
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
    /// Type of RoutingRuleDecision
    /// </summary>
    public enum RoutingRuleDecisionType
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
    public enum PermissionRuleConditionSource
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
    /// Type of PermissionRuleLogic
    /// </summary>
    public enum PermissionRuleLogicType
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
