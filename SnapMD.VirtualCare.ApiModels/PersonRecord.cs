﻿using System;
using System.Collections.Generic;

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
        ///     Gets or sets the photo URL.
        /// </summary>
        /// <value>
        ///     The photo URL.
        /// </value>
        public string PhotoUrl { get; set; }

        /// <summary>
        /// ID of the personal image from person profile
        /// </summary>
        public Guid? ProfileImageId { get; set; }

        /// <summary>
        ///     Gets or sets the hospital identifier.
        /// </summary>
        /// <value>
        ///     The hospital identifier.
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
        ///     Gets or sets the phones.
        /// </summary>
        /// <value>
        ///     The phones.
        /// </value>
        public ICollection<SmallTelecom> Phones { get; set; } = new List<SmallTelecom>();
    }
}
