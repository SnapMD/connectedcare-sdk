using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    public class AppointmentsApi : ApiCall
    {
        public AppointmentsApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public AppointmentsApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        public ApiResponseV2<AppointmentResponse> CreateAppointment(ApiModels.Scheduling.AppointmentApiRequest appointment)
        {
            var response = Post<ApiResponseV2<AppointmentResponse>>("v2.1/patients/appointments", appointment);
            return response;
        }

        /// <summary>
        /// Updates the appointment.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="appointmentRequest">The appointment request.</param>
        /// <returns></returns>
        public ApiResponseV2<AppointmentResponse> UpdateAppointment(Guid appointmentId, AppointmentApiRequest appointmentRequest)
        {
            return
                Put<ApiResponseV2<AppointmentResponse>>(
                    "v2.1/clinicians/appointments/" + appointmentId,
                    appointmentRequest);
        } 

        public void CancelAppointment(Guid appointmentId)
        {
            Delete("v2.1/patients/appointments/" + appointmentId);
        }
    }
}
