using SnapMD.VirtualCare.ApiModels.Scheduling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// DocumentEncounterRequest
    /// </summary>
    public class DocumentEncounterRequest
    {
        /// <summary>
        /// StartTime
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// EndTime
        /// </summary>
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// IntakeMetadata
        /// </summary>
        public AppointmentIntakeMetadata IntakeMetadata { get; set; }

        /// <summary>
        /// Participants
        /// </summary>
        public List<AppointmentParticipantRequest> Participants { get; set; }

    }
}
