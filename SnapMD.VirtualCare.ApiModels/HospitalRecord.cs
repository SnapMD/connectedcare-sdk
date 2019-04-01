namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// A class encapsulating info about a hospital record.
    /// </summary>
    public class HospitalRecord
    {
        /// <summary>
        /// Get or set the Hospital Address 
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Get or set the Hospital Image 
        /// </summary>
        public string HospitalImage { get; set; }

        /// <summary>
        /// Get or set the Hospital Contact Number 
        /// </summary>
        public string ContactNumber { get; set; }

        /// <summary>
        /// Get or set the Hospital Name 
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// Get or set the Hospital Brand Title 
        /// </summary>
        public string BrandTitle { get; set; }
    }
}
