namespace SnapMD.VirtualCare.ApiModels.SiteNotifications
{
    /// <summary>
    ///     Request payload for site notifications.
    /// </summary>
    public class UserSiteNotificationRequest : SiteNotificationRequest
    {
        /// <summary>
        ///     The username of the logged-in user.  This is typically an email address.
        /// </summary>
        /// <value>
        ///     The user.
        /// </value>
        public string User { get; set; }
    }
}