using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    public interface IRuleResponse
    {
        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        int? Version { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created by user identifier.
        /// </summary>
        /// <value>
        /// The created by user identifier.
        /// </value>
        int CreatedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        DateTime? ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the modified by user identifier.
        /// </summary>
        /// <value>
        /// The modified by user identifier.
        /// </value>
        int? ModifiedByUserId { get; set; }
    }

    /// <summary>
    /// Response model for Rule
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.IRuleResponse" />
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.RuleRequest" />
    public class RuleResponse : RuleRequest, IRuleResponse
    {
        /// <summary>
        /// Gets or sets the details json.
        /// </summary>
        /// <value>
        /// The details json.
        /// </value>
        public string DetailsJson { get; set; }

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
