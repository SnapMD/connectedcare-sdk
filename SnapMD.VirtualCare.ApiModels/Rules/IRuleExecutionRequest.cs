using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// The Interface for Rule Execution Request.
    /// </summary>
    public interface IRuleExecutionRequest
    {
        /// <summary>
        /// The category of the rules.
        /// </summary>
        /// <value>
        /// The category.
        /// </value>
        RuleCategoryCode Category { get; }

        /// <summary>
        /// The hospital identifier for filtering the rules.
        /// </summary>
        /// <value>
        /// The hospital identifier.
        /// </value>
        int HospitalId { get; set; }

        /// <summary>
        /// A value indicating whether this <see cref="IRuleExecutionRequest"/> is debug.
        /// </summary>
        /// <value>
        ///   <c>true</c> if debug; otherwise, <c>false</c>.
        /// </value>
        bool? Debug { get; set; }
    }
}
