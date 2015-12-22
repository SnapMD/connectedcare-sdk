using System;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class TelecomResponse
    {
        public Guid Id { get; set; }
        public string Zip { get; set; }
        public string Value { get; set; }
        public int? System { get; set; }
        public int? Use { get; set; }
        public int? Rank { get; set; }
    }
}
