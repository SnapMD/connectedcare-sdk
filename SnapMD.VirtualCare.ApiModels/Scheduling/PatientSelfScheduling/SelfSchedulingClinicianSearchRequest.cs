using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling.PatientSelfScheduling
{
    /// <summary>
    /// Patient self-scheduling clinician search request.
    /// </summary>
    public class SelfSchedulingClinicianSearchRequest
    {
        /// <summary>
        /// Clinician name criteria.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Target patient self-scheduling date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Search for user's my providers.
        /// </summary>
        public bool OnlyMyProviders { get; set; }

        /// <summary>
        /// Gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Practicing since "year from".
        /// </summary>
        public int? PracticingSinceStart { get; set; }

        /// <summary>
        /// Practicing since "year to".
        /// </summary>
        public int? PracticingSinceEnd { get; set; }

        /// <summary>
        /// Items to skip.
        /// </summary>
        public int? Skip { get; set; }

        /// <summary>
        /// Items to take.
        /// </summary>
        public int? Take { get; set; }
    }
}