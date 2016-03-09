using SnapMD.VirtualCare.ApiModels;
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
        public NotificationsApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public NotificationsApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Send notification to connected SignalR user.
        /// </summary>
        public void SendSiteNotification(SiteNotificationRequest notificationRequest)
        {
            Post("v2.1/site-notifications", notificationRequest);
        }
    }
}
