using SnapMD.VirtualCare.ApiModels.Attributes;

namespace SnapMD.VirtualCare.ApiModels.Payments
{
    [ModelName("ApiModels.PaymentSystem")]
    public class PaymentSystem
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public bool NewWindow { get; set; }

        public string ImgUrl { get; set; }

        public string ImgClass { get; set; }

        public string PsTypeId { get; set; }
    }
}
