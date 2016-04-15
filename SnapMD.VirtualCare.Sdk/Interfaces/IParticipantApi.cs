using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IParticipantApi
    {
        ApiResponseV2<AppointmentParticipantResponse> AddParticipant(Guid appointmentId, AppointmentParticipantRequest request);
    }
}
