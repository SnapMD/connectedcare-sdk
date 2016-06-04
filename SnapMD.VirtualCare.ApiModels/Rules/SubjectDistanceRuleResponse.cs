using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Response model for SubjectDistance.
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.IRuleResponse" />
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.SubjectDistanceRuleRequest" />
    public class SubjectDistanceRuleResponse : SubjectDistanceRuleRequest, IRuleResponse
    {
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public int? Version { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created by user identifier.
        /// </summary>
        /// <value>
        /// The created by user identifier.
        /// </value>
        public int CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified by user identifier.
        /// </summary>
        /// <value>
        /// The modified by user identifier.
        /// </value>
        public int? ModifiedByUserId { get; set; }
    }
}
