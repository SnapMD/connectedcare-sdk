namespace SnapMD.VirtualCare.ApiModels.Routing
{
    /// <summary>
    /// Type of RoutingRule
    /// </summary>
    public enum RoutingRuleType
    {
        /// <summary>
        /// The unknown type
        /// </summary>
        Unknown,

        /// <summary>
        /// The patient routing type
        /// </summary>
        PatientRouting
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
    /// Source of Routing Condition
    /// </summary>
    public enum RoutingConditionSource
    {
        /// <summary>
        /// The unknown source
        /// </summary>
        Unknown,

        /// <summary>
        /// The postal code
        /// </summary>
        PostalCode,

        /// <summary>
        /// The distance
        /// </summary>
        Distance
    }

    /// <summary>
    /// Type of RoutingCondition
    /// </summary>
    public enum RoutingConditionType
    {
        /// <summary>
        /// The unknown type
        /// </summary>
        Unknown,

        /// <summary>
        /// The allow type
        /// </summary>
        Allow,

        /// <summary>
        /// The disallow type
        /// </summary>
        Disallow
    }

    /// <summary>
    /// Unit of Routing Distance
    /// </summary>
    public enum RoutingDistanceUnit
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
