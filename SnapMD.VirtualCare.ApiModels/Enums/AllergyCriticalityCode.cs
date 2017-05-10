using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Enums
{
    /// <summary>
    /// Standard criticalities for allergies FHIR datatype.
    /// </summary>
    /// <remarks>
    /// See http://hl7.org/fhir/valueset-allergy-intolerance-criticality.html<br/>
    /// Constant names match FHIR codes, except actual codes are lowercase hyphen-delimited.
    /// </remarks>
    public enum AllergyCriticalityCode
    {
        None = 0,
        Low = 1,
        High = 2,
        UnableToAssess = 3
    }
}
