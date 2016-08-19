using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IAvailabilityBlockAdminApi
    {
        ApiResponseV2<AvailabilityBlockResponse> GetAvailabilityBlocks(AvailabilityBlocksFilter request);

        ApiResponseV2<AvailabilityBlockResponse> CreateAvailabilityBlock(
            AvailabilityBlockRequest availabilityBlockRequest);
    }
}
