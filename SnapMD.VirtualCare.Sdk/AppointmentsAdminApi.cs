﻿using System;
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

        public ApiResponseV2<AppointmentResponse> CreateAppointment(AppointmentApiRequest appointment)
        {
            return Post<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments", appointment);
        }

        public ApiResponseV2<AppointmentResponse> CreateAppointmentFromIntegrations(AppointmentApiRequest appointment)
        {
            return Post<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments/integrations", appointment);
        }

        /// <summary>
        /// Updates the appointment.
        /// </summary>
        /// <param name="appointmentId">The appointment identifier.</param>
        /// <param name="appointment">The appointment.</param>
        /// <returns></returns>
        public ApiResponseV2<AppointmentResponse> UpdateAppointment(Guid appointmentId, AppointmentApiRequest appointment)
        {
            return
                Put<ApiResponseV2<AppointmentResponse>>(
                    "v2.1/clinicians/appointments/" + appointmentId,
                    appointment);
        }

        public ApiResponseV2<AppointmentResponse> UpdateAppointmentFromIntegrations(Guid appointmentId, AppointmentApiRequest appointment)
        {
            return
                Put<ApiResponseV2<AppointmentResponse>>(
                    $"v2.1/clinicians/appointments/{appointmentId}/integrations" ,
                    appointment);
        }


        public ApiResponseV2<AppointmentResponse> GetAppointment(Guid appointmentId)
        {
            return MakeCall<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments/" + appointmentId);
        }

        public void DeleteAppointment(Guid appointmentId)
        {
            Delete($"v2.1/clinicians/appointments/{appointmentId}");
        }

        public void DeleteAppointmentFromIntegration(Guid appointmentId)
        {
            Delete($"v2.1/clinicians/appointments/{appointmentId}/integrations");
        }
    }
}
