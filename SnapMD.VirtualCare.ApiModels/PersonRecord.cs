using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Represents a person record, whether the person is a user, patient, administrator, clinician, dependent, or other.
    /// </summary>
    public class PersonRecord
    {
        /// <summary>
        ///     A globally-unique identifier for the person record.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name in HL-7-compatible format.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public PersonName Name { get; set; } = new PersonName();

        /// <summary>
        ///     Gets or sets the content of the photo.
        /// </summary>
        /// <value>
        ///     The content of the photo.
        /// </value>
        public byte[] PhotoContent { get; set; }

        /// <summary>
        ///     Gets or sets the photo URL.
        /// </summary>
        /// <value>
        ///     The photo URL.
        /// </value>
        public string PhotoUrl { get; set; }

        /// <summary>
        ///     Gets or sets the provider identifier.
        /// </summary>
        /// <value>
        ///     The provider identifier.
        /// </value>
        public int ProviderId { get; set; }

        /// <summary>
        ///     Gets or sets the status code.
        /// </summary>
        /// <value>
        ///     The status code.
        /// </value>
        public GlobalStatusCode StatusCode { get; set; }

        /// <summary>
        /// Contact type code.
        /// </summary>
        public ContactTypeCode ContactTypeCode { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int? UserId { get; set; }

        /// <summary>
        /// Gets or sets the patient identifier.
        /// </summary>
        /// <value>
        /// The patient identifier.
        /// </value>
        public int? PatientId { get; set; }

        /// <summary>
        /// Gets or sets the clinician identifier.
        /// </summary>
        /// <value>
        /// The clinician identifier.
        /// </value>
        public int? ClinicianId { get; set; }
    }
}
