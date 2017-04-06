using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Enums
{
    /// <summary>
    /// Allergies types FHIR datatype.
    /// </summary>
    /// <remarks>
    /// See http://hl7.org/fhir/valueset-allergy-intolerance-type.html<br/>
    /// Constant names match FHIR codes, except actual codes are lowercase.
    /// </remarks>
    public enum AllergyTypeCode
    {
        None = 0,
        Allergy = 1,
        Intolerance = 2
    }
}
