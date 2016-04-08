using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Response for creating a patient profile
    /// </summary>
    public class AddPatientAdminResponseShort
    {
        /// <summary>
        /// Patient Id for the created profile
        /// </summary>
        public int PatientId { get; set; }
    }
}
