﻿using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    /// Encapsulating the Appointments Admin Api.
    /// </summary>
    public class AppointmentsAdminApi : ApiCall, IAppointmentsAdminApi
    {
        /// <summary>
        /// Contructor of Appointments Admin Api.
        /// </summary>
        /// <param name="apiKey"> </param>
        /// <param name="developerId"> </param>
        /// <param name="bearerToken"> </param>
        /// <param name="baseUrl"> </param>
        /// <param name="webClient"> </param>
        public AppointmentsAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Contructor of Appointments Admin Api.
        /// </summary>
        /// <param name="apiKey"> </param>
        /// <param name="developerId"> </param>
        /// <param name="bearerToken"> </param>
        /// <param name="baseUrl"> </param>
        public AppointmentsAdminApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Create Appointment.
        /// </summary>
        /// <param name="appointment"></param>
        public ApiResponseV2<AppointmentResponse> CreateAppointment(AppointmentApiRequest appointment)
        {
            return Post<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments", appointment);
        }

        /// <summary>
        /// Create Appointment FromIntegrations.
        /// </summary>
        /// <param name="appointment"></param>
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

        /// <summary>
        ///Update Appointment From Integrations.
        /// </summary>
        /// <param name="appointment"></param>
        /// <param name="appointmentId"></param>
        public ApiResponseV2<AppointmentResponse> UpdateAppointmentFromIntegrations(Guid appointmentId, AppointmentApiRequest appointment)
        {
            return
                Put<ApiResponseV2<AppointmentResponse>>(
                    $"v2.1/clinicians/appointments/{appointmentId}/integrations" ,
                    appointment);
        }

        /// <summary>
        ///Get Appointment.
        /// </summary>
        /// <param name="appointmentId"></param>
        public ApiResponseV2<AppointmentResponse> GetAppointment(Guid appointmentId)
        {
            return MakeCall<ApiResponseV2<AppointmentResponse>>("v2.1/clinicians/appointments/" + appointmentId);
        }

        /// <summary>
        ///Delete Appointment.
        /// </summary>
        /// <param name="appointmentId"></param>
        public void DeleteAppointment(Guid appointmentId)
        {
            Delete($"v2.1/clinicians/appointments/{appointmentId}");
        }

        /// <summary>
        ///Delete Appointment From Integration.
        /// </summary>
        /// <param name="appointmentId"></param>
        public void DeleteAppointmentFromIntegration(Guid appointmentId)
        {
            Delete($"v2.1/clinicians/appointments/{appointmentId}/integrations");
        }
    }
}
