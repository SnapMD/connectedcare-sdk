namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// The object used to encapsulate a Doctor Record.
    /// </summary>
    public class DoctorRecord
    {
        /// <summary>
        /// Doctor First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Doctor Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Doctor Medical Speciality
        /// </summary>
        public string MedicalSpeciality { get; set; }

        /// <summary>
        /// Doctor business Address
        /// </summary>
        public string BusinessAddress { get; set; }
    }
}
