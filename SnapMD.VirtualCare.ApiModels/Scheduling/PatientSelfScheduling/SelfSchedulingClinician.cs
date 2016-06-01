using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling.PatientSelfScheduling
{
    /// <summary>
    /// Patient self-scheduling clinician search result.
    /// </summary>
    public class SelfSchedulingClinician
    {
        /// <summary>
        /// User id.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Person id.
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Person profile image.
        /// </summary>
        public string ProfilePhoto { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// States licenced.
        /// </summary>
        public string StatesLicenced { get; set; }

        /// <summary>
        /// Is my provider.
        /// </summary>
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Medical speciality.
        /// </summary>
        public string MedicalSpeciality { get; set; }

        /// <summary>
        /// Medical sub-speciality.
        /// </summary>
        public string SubSpeciality { get; set; }

        /// <summary>
        /// Date of birth.
        /// </summary>
        public DateTime? Dob { get; set; }

        /// <summary>
        /// Practicing since year.
        /// </summary>
        public int? PracticingSince { get; set; }

        /// <summary>
        /// Available appointment slots.
        /// </summary>
        public List<AppointmentSlot> Slots { get; set; }
    }
}