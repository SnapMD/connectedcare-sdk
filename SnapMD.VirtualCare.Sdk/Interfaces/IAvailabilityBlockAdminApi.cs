using System;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Scheduling;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    /// <summary>
    /// Represent the Interface IAvailability Block Admin Api.
    /// </summary>
    public interface IAvailabilityBlockAdminApi
    {
        /// <summary>
        /// Get the Availability Blocks
        /// </summary>
        /// <param name="request"> Clinician Id , CaregiversIds,Groups </param>
        /// <returns>Availability of the block</returns>
        ApiResponseV2<AvailabilityBlockResponse> GetAvailabilityBlocks(AvailabilityBlocksFilter request);

        /// <summary>
        /// Create the Availability Blocks
        /// </summary>
        /// <param name="availabilityBlockRequest"> End time , Start Time </param>
        /// <returns>Availability of the block</returns>
        ApiResponseV2<AvailabilityBlockResponse> CreateAvailabilityBlock(AvailabilityBlockRequest availabilityBlockRequest);

        /// <summary>
        /// Delete the Availability Blocks
        /// </summary>
        /// <param name="blockId"></param>
        void DeleteAvailabilityBlock(Guid blockId);
    }
}
