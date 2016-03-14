using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Appointment creation questionnaire (IntakeMetadata).
    /// </summary>
    public class AppointmentIntakeMetadata
    {
        /// <summary>
        /// Patient concerns.
        /// </summary>
        public List<EncounterConcern> Concerns { get; set; }

        /// <summary>
        /// Additioal text information.
        /// </summary>
        public string AdditionalNotes { get; set; }
    }
}
