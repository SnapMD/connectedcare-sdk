using System;
using SnapMD.VirtualCare.ApiModels;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IFileSharingApi
    {
        ApiResponseV2<ConsultationFolderResponse> GetConsultationFolder(int consultationId);

        ApiResponse<Uri> GetDownloadLink(string fileId, int? consultationId = null);
    }
}
