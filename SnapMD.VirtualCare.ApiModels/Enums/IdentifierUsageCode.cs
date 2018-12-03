using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Enums
{
    /// <summary>
    /// Standard usages for FHIR identifier datatype.
    /// </summary>
    /// <remarks>
    /// See http://hl7.org/fhir/valueset-identifier-use.html<br/>
    /// Enum constant names are intentionally lowercase, so ToString() and Parse() methods correctly 
    /// represent case-sensitive FHIR codes.
    /// </remarks>
    public enum IdentifierUsageCode
    {
        /// <summary>
        ///   Identifier Usage is None.
        /// </summary>
        /// <value>
        /// code is 0.
        /// </value>
        none = 0,
        /// <summary>
        ///   Identifier Usage is usual.
        /// </summary>
        /// <value>
        /// code is 1.
        /// </value>
        usual = 1,
        /// <summary>
        ///   Identifier Usage is official.
        /// </summary>
        /// <value>
        /// code is 2.
        /// </value>
        official = 2,
        /// <summary>
        ///   Identifier Usage is temp.
        /// </summary>
        /// <value>
        /// code is 3.
        /// </value>
        temp = 3,
        /// <summary>
        ///   Identifier Usage is secondary.
        /// </summary>
        /// <value>
        /// code is 4.
        /// </value>
        secondary = 4
    }
}
