using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Encapsultae the Hospital Hours
    /// </summary>
    public struct HospitalHours
    {
        /// <summary>
        ///     Gets or sets the StartDayOfWeek.
        /// </summary>
        /// <value>
        ///     Start Day Of the Week Sunday.
        /// </value>
        public int StartDayOfWeek { get; set; }
        /// <summary>
        ///     Gets or sets the EndDayOfWeek.
        /// </summary>
        /// <value>
        ///     End Day Of Week Saturday.
        /// </value>
        public int EndDayOfWeek { get; set; }
        /// <summary>
        ///     Gets or sets the StartTime.
        /// </summary>
        /// <value>
        ///    StartTime.
        /// </value>
        public TimeSpan StartTime { get; set; }
        /// <summary>
        ///     Gets or sets the EndTime.
        /// </summary>
        /// <value>
        ///    EndTime.
        /// </value>
        public TimeSpan EndTime { get; set; }
    }
}
