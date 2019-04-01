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
        /// <summary>
        ///  Allergy Category None.
        /// </summary>
        /// <value>
        /// code is 0.
        /// </value>
        None = 0,
        /// <summary>
        ///  Allergy Category Food.
        /// </summary>
        /// <value>
        /// code is 1.
        /// </value>
        Food = 1,
        /// <summary>
        ///  Allergy Category Medication.
        /// </summary>
        /// <value>
        /// code is 2.
        /// </value>
        Medication = 2,
        /// <summary>
        ///  Allergy Category Environment.
        /// </summary>
        /// <value>
        /// code is 3.
        /// </value>
        Environment = 3,
        /// <summary>
        ///  Allergy Category Biologic.
        /// </summary>
        /// <value>
        /// code is 4.
        /// </value>
        Biologic = 4
    }
}
