namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlocksResponse
    {
        public AvailabilityBlockResponse[] AvailabilityBlocks { get; set; }

        public AvailabilityBlockRuleResponse[] AvailabilityBlockRules { get; set; }
    }
}
