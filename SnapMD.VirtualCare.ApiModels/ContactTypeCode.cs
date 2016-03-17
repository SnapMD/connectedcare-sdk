namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Person's contact type.
    /// </summary>
    public enum ContactTypeCode
    {
        /// <summary>
        /// Contact (default).
        /// </summary>
        Contact,

        /// <summary>
        /// Patient.
        /// </summary>
        Patient,

        /// <summary>
        /// Practicioner.
        /// </summary>
        Practicioner,

        /// <summary>
        /// Hospital Admin.
        /// </summary>
        HospitalAdmin,

        /// <summary>
        /// Snap MD Staff.
        /// </summary>
        SnapMDStaff
    }
}