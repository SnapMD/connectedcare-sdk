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
        /// <summary>
        /// Allergy Criticality Code field name is None
        /// </summary>
        /// <value> 0 </value>
        None = 0,
        /// <summary>
        /// Allergy Criticality Code field name is None
        /// </summary>
        /// <value> 1 </value>
        Low = 1,
        /// <summary>
        /// Allergy Criticality Code field name is High
        /// </summary>
        /// <value> 2 </value>
        High = 2,
        /// <summary>
        /// Allergy Criticality Code field name is Unable To Assess
        /// </summary>
        /// <value> 3 </value>
        UnableToAssess = 3
    }
}
