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
        /// Return only clinicians, that are available on target date.
        /// </summary>
        public bool AvailableOnly { get; set; }

        /// <summary>
        /// Search for user's my providers.
        /// </summary>
        public bool OnlyMyProviders { get; set; }

        /// <summary>
        /// Filter providers using visibility rules
        /// </summary>
        public bool ApplyVisibilityRules { get; set; }

        /// <summary>
        /// PatientId for visibility rules (must be an authorized dependent of current user) or 
        /// null for whole family of current user
        /// </summary>
        public int? PatientId { get; set; }

        /// <summary>
        /// Gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// List of genders to include into response. 
        /// Use of <see cref="Genders"/> and <see cref="Gender"/> is mutually exclusive.
        /// </summary>
        public string[] Genders { get; set; }

        /// <summary>
        /// Practicing since "year from".
        /// </summary>
        public int? PracticingSinceStart { get; set; }

        /// <summary>
        /// Practicing since "year to".
        /// </summary>
        public int? PracticingSinceEnd { get; set; }

        /// <summary>
        /// Ids of departments to search in.
        /// </summary>
        public int[] DepartmentsIds { get; set; }

        /// <summary>
        /// Ids of specialities to search for.
        /// </summary>
        public int[] MedicalSpecialitiesIds { get; set; }
        
        /// <summary>
        /// Ids of subspecialities to search for.
        /// </summary>
        public int?[] SubspecialitiesIds { get; set; }

        /// <summary>
        /// Items to skip.
        /// </summary>
        public int? Skip { get; set; }

        /// <summary>
        /// Items to take.
        /// </summary>
        public int? Take { get; set; }

        /// <summary>
        /// ServiceTypeId
        /// </summary>
        public int? ServiceTypeId { get; set; }

        /// <summary>
        /// Get a shallow copy of the request.
        /// </summary>
        /// <returns>Copy of the current request</returns>
        public SelfSchedulingClinicianSearchRequest Clone() => (SelfSchedulingClinicianSearchRequest)MemberwiseClone();
    }
}
