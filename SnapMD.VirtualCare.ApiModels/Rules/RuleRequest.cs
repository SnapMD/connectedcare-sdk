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
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the satisfied message.
        /// </summary>
        /// <value>
        /// The satisfied message.
        /// </value>
        public string SatisfiedMessage { get; set; }

        /// <summary>
        /// Gets or sets the unsatisfied message.
        /// </summary>
        /// <value>
        /// The unsatisfied message.
        /// </value>
        public string UnsatisfiedMessage { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        public GlobalStatusCode? StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the maximum rows should be returned from the search results.
        /// </summary>
        /// <value>
        /// The maximum rows.
        /// </value>
        public int? MaxRows { get; set; }
    }

    /// <summary>
    /// Request model for Rule
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.RuleRequestBase" />
    public class RuleRequest : RuleRequestBase
    {
        /// <summary>
        /// Gets or sets the rule template identifier.
        /// </summary>
        /// <value>
        /// The rule template identifier.
        /// </value>
        public Guid? RuleTemplateId { get; set; }

        /// <summary>
        /// Gets or sets the provider identifier.
        /// </summary>
        /// <value>
        /// The provider identifier.
        /// </value>
        public int? ProviderId { get; set; }

        /// <summary>
        /// Gets or sets the condition type identifier.
        /// </summary>
        /// <value>
        /// The condition type identifier.
        /// </value>
        public RuleLogicTypeCode? ConditionTypeId { get; set; }

        /// <summary>
        /// Gets or sets the condition source.
        /// </summary>
        /// <value>
        /// The condition source.
        /// </value>
        public RuleConditionSource? ConditionSource { get; set; }

        /// <summary>
        /// Gets or sets the sequence.
        /// </summary>
        /// <value>
        /// The sequence.
        /// </value>
        public int? Sequence { get; set; }
    }
}
