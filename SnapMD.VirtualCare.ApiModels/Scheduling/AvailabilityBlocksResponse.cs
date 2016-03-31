namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    public class AvailabilityBlocksResponse
    {
        public AvailabilityBlockResponse[] AvailabilityBlocks { get; set; }

        public AvailabilityBlockRuleRequest[] AvailabilityBlockRules { get; set; }
    }
}
