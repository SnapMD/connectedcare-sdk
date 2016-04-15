namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// </summary>
    /// <seealso cref="ImageUploadResponse" />
    public class ProfileImageResponse : ImageUploadResponse
    {
        /// <summary>
        ///     Gets or sets the URI base64.
        /// </summary>
        /// <value>
        ///     The URI base64.
        /// </value>
        public string UriBase64 { get; set; }
    }
}