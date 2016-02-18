namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    public class AvailabilityBlocksResponse
    {
        public AvailabilityBlockResponse[] AvailabilityBlocks { get; set; }

        public AvailabilityBlockRuleResponse[] AvailabilityBlockRules { get; set; }
    }
}
