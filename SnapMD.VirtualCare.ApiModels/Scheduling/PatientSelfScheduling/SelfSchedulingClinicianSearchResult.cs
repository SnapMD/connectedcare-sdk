using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling.PatientSelfScheduling
{
    /// <summary>
    /// Self-scheduling clinicians search results and grouping totals.
    /// </summary>
    public class SelfSchedulingClinicianSearchResult
    {
        /// <summary>
        /// Found clinicians.
        /// </summary>
        public List<SelfSchedulingClinician> Clinicians { get; set; }

        /// <summary>
        /// Grouping totals.
        /// </summary>
        public Dictionary<string, int> Totals { get; set; }
    }
}
