using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    ///     This Participant Api.
    /// </summary>
    public class ParticipantApi : ApiCall, IParticipantApi
    {
        /// <summary>
        ///   Participant Api Constructor.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUrl"></param>
        /// <param name="bearerToken"></param>
        /// <param name="client"></param>
        /// <param name="developerId"></param>
        public ParticipantApi(string baseUrl, IWebClient client, string bearerToken = null, string developerId = null, string apiKey = null) : base(baseUrl, client, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        ///     Add Participant .
        /// </summary>
        /// <value>
        ///   <paramref name="appointmentId"/>
        ///   <paramref name="appointmentId"/>
        ///   <paramref name="request"/>
        /// </value>
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
