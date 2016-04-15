using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Models;
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

        public ApiResponseV2<AppointmentResponse> CreateAppointment(AppointmentRequest appointment)
        {
            var response = Post<ApiResponseV2<AppointmentResponse>>("v2.1/patients/appointments", appointment);
            return response;
        }

        public void CancelAppointment(Guid appointmentId)
        {
            Delete("v2.1/patients/appointments/" + appointmentId);
        }

        public ApiResponseV2<AppointmentParticipantResponse> AddParticipant(Guid appointmentId,
            AppointmentParticipantRequest participantRequest)
        {
            var path = GetParticipantsPath(appointmentId);
            var response = Post<ApiResponseV2<AppointmentParticipantResponse>>(path, participantRequest);
            return response;
        }

        public ApiResponseV2<AppointmentParticipantResponse> GetParticipants(Guid appointmentId)
        {
            var path = GetParticipantsPath(appointmentId);
            var response = MakeCall<ApiResponseV2<AppointmentParticipantResponse>>(path);
            return response;
        }

        private static string GetParticipantsPath(Guid appointmentId)
        {
            var path = string.Format("v2.1/clinicians/appointments/{0}/participants", appointmentId);
            return path;
        }
    }
}
