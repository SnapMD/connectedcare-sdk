using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// EncounterTypeCode for the appointment
    /// </summary>
    public enum EncounterTypeCode
    {
        /// <summary>
        /// None
        /// </summary>
        None,

        /// <summary>
        /// Text
        /// </summary>
        Text,

        /// <summary>
        /// Phone
        /// </summary>
        Phone,

        /// <summary>
        /// Video
        /// </summary>
        Video,

        /// <summary>
        /// InPerson
        /// </summary>
        InPerson
    }
}
