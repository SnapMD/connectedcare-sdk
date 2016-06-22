using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Base of RuleRequest classes
    /// </summary>
    public abstract class RuleRequestBase
    {
        /// <summary>
        /// The identifier of the rule, rule template or rule set.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid? Id { get; set; }

        /// <summary>
        /// The description of the object.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// The satisfied message, when a rule is executed with postive result.
        /// </summary>
        /// <value>
        /// The satisfied message.
        /// </value>
        public string SatisfiedMessage { get; set; }

        /// <summary>
        /// The unsatisfied message, when a rule is executed with negative result.
        /// </summary>
        /// <value>
        /// The unsatisfied message.
        /// </value>
        public string UnsatisfiedMessage { get; set; }

        /// <summary>
        /// The status code of request filter or respose object.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        public GlobalStatusCode? StatusCode { get; set; }

        /// <summary>
        /// The maximum rows should be returned from the search results.
        /// </summary>
        /// <value>
        /// The maximum rows.
        /// </value>
        public int? MaxRows { get; set; }
    }

    /// <summary>
    /// Request model for Rule
    /// </summary>
    /// <seealso cref="RuleRequestBase" />
    public class RuleRequest : RuleRequestBase
    {
        /// <summary>
        /// The rule template identifier of the rule.
        /// A rule template define the logic of the rules.
        /// </summary>
        /// <value>
        /// The rule template identifier.
        /// </value>
        public Guid? RuleTemplateId { get; set; }

        /// <summary>
        /// The provider identifier that the rule belongs to.
        /// </summary>
        /// <value>
        /// The provider identifier.
        /// </value>
        public int? ProviderId { get; set; }

        /// <summary>
        /// The condition type identifier.
        /// In (+) / NotIn (-) * rule evaluation result.
        /// e.g. For subject address rule: NotIn US CA Los Angeles,
        /// a subject address in anywhere other than Los Angeles will satisfy this rule.
        /// </summary>
        /// <value>
        /// The condition type identifier.
        /// </value>
        public RuleLogicTypeCode? ConditionTypeId { get; set; }

        /// <summary>
        /// The condition source.
        /// Indicates how a rule which rule condition should be evaluated.
        /// e.g. For organization location: In Organization X, Location Y
        /// ConditionSource: Organization => X is required.
        /// ConditionSource: OrganizationLocation => X and Y are required.
        /// </summary>
        /// <value>
        /// The condition source.
        /// </value>
        public RuleConditionSource? ConditionSource { get; set; }

        /// <summary>
        /// The sequence of the rule to be ordered on fetch.
        /// </summary>
        /// <value>
        /// The sequence.
        /// </value>
        public int? Sequence { get; set; }
    }
}
