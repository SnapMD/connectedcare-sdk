using System;
using System.Linq;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk
{
    public class AvailabilityBlockAdminApi : ApiCall, IAvailabilityBlockAdminApi
    {
        public AvailabilityBlockAdminApi(string baseUrl, IWebClient client, string bearerToken = null, string developerId = null, string apiKey = null) : base(baseUrl, client, bearerToken, developerId, apiKey)
        {
        }

        public ApiResponseV2<AvailabilityBlockResponse> GetAvailabilityBlocks(AvailabilityBlocksFilter request)
        {
            var clinicianIds =
                request.ClinicianIds != null && request.ClinicianIds.Length > 0
                    ? request.ClinicianIds.Select(x => x.ToString()).Aggregate((p, n) => p + "," + n)
                    : "";
            var groups =
                request.Groups != null && request.Groups.Length > 0
                    ? request.Groups.Select(x => x.ToString()).Aggregate((p, n) => p + "," + n)
                    : "";

            if (!request.StartDate.HasValue)
            {
                throw new SnapSdkException("Start Date is required to get an availability block");
            }

            var result = MakeCall<ApiResponseV2<AvailabilityBlockResponse>>
                (
                    $"v2.1/clinicians/availability-blocks?ClinicianIds={clinicianIds}&Groups={groups}&StartDate={request.StartDate.Value.ToString("yyyy-MM-dd")}&EndDate={(request.EndDate.HasValue ? request.EndDate.Value.ToString("yyyy-MM-dd") : "")}"
                );

            return result;
        }

        public ApiResponseV2<AvailabilityBlockResponse> CreateAvailabilityBlock(AvailabilityBlockRequest availabilityBlockRequest)
        {
            var result = Post<ApiResponseV2<AvailabilityBlockResponse>>("v2.1/clinicians/availability-blocks", availabilityBlockRequest);

            return result;
        }

        public void DeleteAvailabilityBlock(Guid blockId)
        {
            Delete("v2.1/clinicians/availability-blocks/" + blockId);
        }
    }
}
