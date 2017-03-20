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
        none = 0,
        usual = 1,
        official = 2,
        temp = 3,
        secondary = 4
    }
}
