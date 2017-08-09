using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Enums
{
    /// <summary>
    /// Allergies categories FHIR datatype.
    /// </summary>
    /// <remarks>
    /// See http://hl7.org/fhir/valueset-allergy-intolerance-category.html<br/>
    /// Constant names match FHIR codes, except actual codes are lowercase.
    /// </remarks>
    public enum AllergyCategoryCode
    {
        None = 0,
        Food = 1,
        Medication = 2,
        Environment = 3,
        Biologic = 4
    }
}
