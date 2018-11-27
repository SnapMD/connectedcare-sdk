using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    /// <summary>
    /// Represent IAppointments Admin Api.
    /// </summary>
    public interface IAppointmentsAdminApi
    {
        /// <summary>
        ///    Create CreateAppointment.
        /// </summary>
        /// <param name="appointment"></param>
        /// <value>
        /// Return AppointmentResponse.
        /// </value>
        ApiResponseV2<AppointmentResponse> CreateAppointment(AppointmentApiRequest appointment);
        /// <summary>
        ///    Create CreateAppointment from Integrations.
        /// </summary>
        /// <param name="appointment"></param>
        /// <value>
        /// Return AppointmentResponse.
        /// </value>
        ApiResponseV2<AppointmentResponse> CreateAppointmentFromIntegrations(AppointmentApiRequest appointment);
        /// <summary>
        ///    Update Appointment.
        /// </summary>
        /// <value>
        /// Return AppointmentResponse.
        /// <paramref name="appointmentId"/>
        /// <paramref name="appointment"/>
        /// </value>
        ApiResponseV2<AppointmentResponse> UpdateAppointment(Guid appointmentId, AppointmentApiRequest appointment);
        /// <summary>
        ///    Update UpdateAppointment From Integrations.
        /// </summary>
        /// <param name="appointment"></param>
        /// <param name="appointmentId"></param>
        /// <value>
        /// Return UpdateAppointmentFromIntegrations.
        /// </value>
        ApiResponseV2<AppointmentResponse> UpdateAppointmentFromIntegrations(Guid appointmentId,
            AppointmentApiRequest appointment);
        /// <summary>
        ///   Get Appointment.
        /// </summary>
        /// <param name="appointmentId"></param>
        /// <value>
        /// Return Get Appointment.
        /// </value>
        ApiResponseV2<AppointmentResponse> GetAppointment(Guid appointmentId);
        /// <summary>
        ///   Delete Appointment.
        /// </summary>
        /// <param name="appointmentId"></param>
        void DeleteAppointment(Guid appointmentId);
        /// <summary>
        ///   Delete Appointment From Integration.
        /// </summary>
        /// <param name="appointmentId"></param>
        void DeleteAppointmentFromIntegration(Guid appointmentId);
    }
}
