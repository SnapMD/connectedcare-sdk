namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Request payload for site notifications.
    /// </summary>
    public class SiteNotificationRequest
    {
        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        /// <value>
        ///     The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets the type of the message.
        /// </summary>
        /// <value>
        ///     The type of the message.  Supported values are "info", "confirmation", "announcement", "email", "success",
        ///     "warning", and "error".
        /// </value>
        public string MessageType { get; set; }

        /// <summary>
        ///     The username of the logged-in user.  This is typically an email address.
        /// </summary>
        /// <value>
        ///     The user.
        /// </value>
        public string User { get; set; }
    }
}