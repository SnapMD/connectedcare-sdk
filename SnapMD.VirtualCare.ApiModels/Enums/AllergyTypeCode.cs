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
        /// <summary>
        ///  Allergy Type None.
        /// </summary>
        /// <value>
        /// code is 0.
        /// </value>
        None = 0,
        /// <summary>
        ///  Allergy Type Allergy.
        /// </summary>
        /// <value>
        /// code is 1.
        /// </value>
        Allergy = 1,
        /// <summary>
        ///  Allergy Type Intolerance.
        /// </summary>
        /// <value>
        /// code is 2.
        /// </value>
        Intolerance = 2
    }
}
