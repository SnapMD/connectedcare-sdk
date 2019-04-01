using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    /// <summary>
    /// Represent IParticipant Api.
    /// </summary>
    public interface IParticipantApi
    {
        /// <summary>
        ///   Add Participant.
        /// </summary>
        ///param name="appointmentId"
        ///param name="request"
        /// <value>
        /// Return AppointmentResponse.
        /// </value>
        ApiResponseV2<AppointmentParticipantResponse> AddParticipant(Guid appointmentId, AppointmentParticipantRequest request);
    }
}
