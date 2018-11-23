using SnapMD.VirtualCare.ApiModels.SiteNotifications;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    ///     This API is currently for internal use only.
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.Sdk.ApiCall" />
    public class NotificationsApi : ApiCall
    {
        /// <summary>
        ///    contructor NotificationsApi.
        /// </summary>
        /// <value>
        ///    <paramref name="apiKey"/>
        ///    <paramref name="baseUrl"/>
        ///    <paramref name="bearerToken"/>
        ///    <paramref name="developerId"/>
        ///    <paramref name="webClient"/>
        /// </value>
        public NotificationsApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        ///    contructor NotificationsApi.
        /// </summary>
        /// <value>
        ///    <paramref name="apiKey"/>
        ///    <paramref name="baseUrl"/>
        ///    <paramref name="bearerToken"/>
        ///    <paramref name="developerId"/>
        /// </value>
        public NotificationsApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        ///     Send notification to connected SignalR user.
        /// </summary>
        public void SendSiteNotification(UserSiteNotificationRequest notificationRequest)
        {
            Post("v2.1/site-notifications", notificationRequest);
        }

        /// <summary>
        ///     Send notification to all connected SignalR users of a particular provider.
        /// </summary>
        public void SendProviderSiteNotification(int providerId, SiteNotificationRequest notificationRequest)
        {
            Post($"v2.1/site-notifications/{providerId}", notificationRequest);
        }
    }
}
