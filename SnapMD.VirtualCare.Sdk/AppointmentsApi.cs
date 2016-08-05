using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    public class AppointmentsApi : ApiCall
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentsApi"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="bearerToken">The bearer token.</param>
        /// <param name="developerId">The developer identifier.</param>
        /// <param name="apiKey">The API key.</param>
        /// <param name="webClient">The web client.</param>
        public AppointmentsApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppointmentsApi"/> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="bearerToken">The bearer token.</param>
        /// <param name="developerId">The developer identifier.</param>
        /// <param name="apiKey">The API key.</param>
        public AppointmentsApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Creates an appointment scheduled for a future date.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        /// <returns></returns>
        public ApiResponseV2<AppointmentResponse> CreateAppointment(AppointmentRequest appointment)
        {
            var response = Post<ApiResponseV2<AppointmentResponse>>("v2.1/patients/appointments", appointment);
            return response;
        }

        /// <summary>
        /// Cancels an existing appointment. If you've already cancelled the appointment it will return 404.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        public void CancelAppointment(Guid appointmentId)
        {
            Delete("v2.1/patients/appointments/" + appointmentId);
        }
    }
}
