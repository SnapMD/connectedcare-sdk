using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Interfaces;
using SnapMD.VirtualCare.Sdk.Wrappers;

namespace SnapMD.VirtualCare.Sdk
{
    public class FileSharingApi : ApiCall, IFileSharingApi
    {
        public FileSharingApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey,
            IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        public FileSharingApi(
            string baseUrl,
            string bearerToken,
            string developerId,
            string apiKey)
            : base(baseUrl, new WebClientWrapper(), bearerToken, developerId, apiKey)
        {
        }

        public ApiResponseV2<ConsultationFolderResponse> GetConsultationFolder(int consultationId)
        {
            string url = string.Format("v2.1/integrations/filesharing/consultations/{0}", consultationId);
            var result = MakeCall<ApiResponseV2<ConsultationFolderResponse>>(url);
            return result;
        }

        public ApiResponse<Uri> GetDownloadLink(string fileId, int? consultationId = null)
        {
            string url = string.Format("v2.1/integrations/filesharing/file?fileId={0}", fileId);
            var result = MakeCall<ApiResponse<Uri>>(url);
            return result;
        }

    }
}
