using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// </summary>
    public class ImageUploadResponse
    {
        /// <summary>
        ///     Gets or sets the identifier.
        /// </summary>
        /// <value>
        ///     The identifier.
        /// </value>
        public Guid? Id { get; set; }

        /// <summary>
        ///     Gets or sets the URI.
        /// </summary>
        /// <value>
        ///     The URI.
        /// </value>
        public string Uri { get; set; }
    }
}