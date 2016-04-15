using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Models;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    public interface IAvailabilityBlockAdminApi
    {
        ApiResponseV2<AvailabilityBlockResponse> GetAvailabilityBlocks(AvailabilityBlocksRequest request);

        ApiResponseV2<AvailabilityBlockResponse> CreateAvailabilityBlock(AvailabilityBlockRequest availabilityBlockRequest);
    }
}
