using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    public class AppointmentsAdminApi : ApiCall, IAppointmentsAdminApi
    {
        public AppointmentsAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public AppointmentsAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        public ApiResponseV2<AppointmentResponse> CreateAppointment(NewAppointmentRequest appointment)
        {
            return Post<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments", appointment);
        }

        /// <summary>
        /// Updates the appointment.
        /// </summary>
        /// <param name="appointment">The appointment.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">Appointment request is missing ID.</exception>
        public ApiResponseV2<AppointmentResponse> UpdateAppointment(EditAppointmentRequest appointment)
        {
            if (appointment.AppointmentId == null || appointment.AppointmentId == Guid.Empty)
            {
                throw new ArgumentException("Appointment request is missing ID.");
            }

            return
                Put<ApiResponseV2<AppointmentResponse>>(
                    "v2.1/clinicians/appointments/" + appointment.AppointmentId.Value,
                    appointment);
        }

        public ApiResponseV2<AppointmentResponse> GetAppointment(Guid appointmentId)
        {
            return MakeCall<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments/" + appointmentId);
        }

        public void DeleteAppointment(Guid appointmentId)
        {
            Delete("v2.1/clinicians/appointments/" + appointmentId);
        }
    }
}
