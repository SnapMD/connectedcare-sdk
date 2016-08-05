namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
	/// <summary>
	/// The response model for Availability Block APIs.
	/// </summary>
    public class AvailabilityBlocksResponse
    {
        public AvailabilityBlockResponse[] AvailabilityBlocks { get; set; }

        public AvailabilityBlockRuleRequest[] AvailabilityBlockRules { get; set; }
    }
}
