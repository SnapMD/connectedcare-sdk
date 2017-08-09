using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IAppointmentsAdminApi
    {
        ApiResponseV2<AppointmentResponse> CreateAppointment(AppointmentApiRequest appointment);
        ApiResponseV2<AppointmentResponse> CreateAppointmentFromIntegrations(AppointmentApiRequest appointment);
        ApiResponseV2<AppointmentResponse> UpdateAppointment(Guid appointmentId, AppointmentApiRequest appointment);
        ApiResponseV2<AppointmentResponse> UpdateAppointmentFromIntegrations(Guid appointmentId,
            AppointmentApiRequest appointment);
        ApiResponseV2<AppointmentResponse> GetAppointment(Guid appointmentId);
        void DeleteAppointment(Guid appointmentId);
        void DeleteAppointmentFromIntegration(Guid appointmentId);
    }
}
