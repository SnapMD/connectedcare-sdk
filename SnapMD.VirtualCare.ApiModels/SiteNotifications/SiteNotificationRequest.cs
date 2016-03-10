namespace SnapMD.VirtualCare.ApiModels.SiteNotifications
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
    }
}
