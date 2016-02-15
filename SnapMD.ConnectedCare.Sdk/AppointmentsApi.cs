using System;
using SnapMD.ConnectedCare.ApiModels.Scheduling;
using SnapMD.ConnectedCare.ApiModels.Scheduling.SnapMD.Core.Models.Scheduling;
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
            var response = Post<ApiResponseV2<Appointment>>("v2.1/patients/appointments", appointment);
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
