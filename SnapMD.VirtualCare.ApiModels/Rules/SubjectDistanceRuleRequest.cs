using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Request model for SubjectDistance
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Rules.RuleRequest" />
    public class SubjectDistanceRuleRequest : RuleRequest
    {
        /// <summary>
        /// Gets or sets the center.
        /// </summary>
        /// <value>
        /// The center.
        /// </value>
        public GeoCoordinate Center { get; set; }

        /// <summary>
        /// Gets or sets the distance.
        /// </summary>
        /// <value>
        /// The distance.
        /// </value>
        public decimal? Distance { get; set; }

        /// <summary>
        /// Gets or sets the distance unit.
        /// </summary>
        /// <value>
        /// The distance unit.
        /// </value>
        public GeoDistanceUnit? DistanceUnit { get; set; }
    }
}
