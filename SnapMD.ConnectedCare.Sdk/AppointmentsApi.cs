using System;
using SnapMD.ConnectedCare.ApiModels.Scheduling;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;
using SnapMD.ConnectedCare.Sdk.Wrappers;

namespace SnapMD.ConnectedCare.Sdk
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

        public ApiResponseV2<Appointment> CreateAppointment(Appointment appointment)
        {
            var response = Post<ApiResponseV2<Appointment>>("v2/patients/appointments", appointment);
            return response;
        }

        public void CancelAppointment(Guid appointmentId)
        {
            Delete("v2/patients/appointments/" + appointmentId);
        }
    }
}
