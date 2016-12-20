using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    /// <summary>
    /// Response model for provider-patient visibility rules
    /// </summary>
    public class CompoundVisibilityResponse
    {
        /// <summary>
        /// Was rule evaluation successful - are provider and patient able see each other?
        /// </summary>
        public bool IsVisible { get; set; }

        /// <summary>
        /// Additional comment or error message (optional)
        /// </summary>
        public string Message { get; set; }
    }
}
