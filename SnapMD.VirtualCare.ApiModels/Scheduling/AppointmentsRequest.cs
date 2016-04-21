using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    /// Request model for Appointments search filter 
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.ApiModels.Scheduling.AvailabilityBlocksRequest" />
    public class AppointmentsRequest : AvailabilityBlocksRequest
    {
        /// <summary>
        /// The appointment type codes to be searched.
        /// </summary>
        /// <value>
        /// The appointment type codes.
        /// </value>
        public AppointmentTypeCode[] AppointmentTypeCodes { get; set; }

        /// <summary>
        /// The appointment status codes to be searched.
        /// </summary>
        /// <value>
        /// The appointment status codes.
        /// </value>
        public AppointmentStatusCode[] AppointmentStatusCodes { get; set; }

        /// <summary>
        /// The patient user identifier.  Filters patient appointments.
        /// </summary>
        /// <value>
        /// The patient user identifier.
        /// </value>
        public int? PatientUserId { get; set; }

        /// <summary>
        /// Patient Identifiers, Filter for searching appointments for list of patients.
        /// </summary>
        public int[] PatientIds { get; set; }

        /// <summary>
        /// Flag indicates search should include patient dependents or not.
        /// </summary>
        /// <value>
        /// The include patient dependents.
        /// </value>
        public bool? IncludePatientDependents { get; set; }
    }
}
