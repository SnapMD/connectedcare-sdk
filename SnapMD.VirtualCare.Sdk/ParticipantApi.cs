using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk
{
    public class ParticipantApi : ApiCall, IParticipantApi
    {
        public ParticipantApi(string baseUrl, IWebClient client, string bearerToken = null, string developerId = null, string apiKey = null) : base(baseUrl, client, bearerToken, developerId, apiKey)
        {
        }

        public ApiResponseV2<AppointmentParticipantResponse> AddParticipant(Guid appointmentId, AppointmentParticipantRequest request)
        {
            var result = Post<ApiResponseV2<AppointmentParticipantResponse>>
                (
                    $"v2.1/clinicians/appointments/{appointmentId}/participants",
                    request
                );

            return result;
        }
    }
}
