using SnapMD.VirtualCare.ApiModels.Scheduling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// DocumentEncounterResponse
    /// </summary>
    public class DocumentEncounterResponse : DocumentEncounterRequest
    {
        //TODO: May be not required. Revisit this
        //public new List<AppointmentParticipantResponse> Participants { get; set; }

        /// <summary>
        /// ConsultationId
        /// </summary>
        public int? ConsultationId { get; set; }
    }
}
