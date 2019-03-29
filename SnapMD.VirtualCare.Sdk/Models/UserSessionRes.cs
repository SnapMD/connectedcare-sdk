using System;

namespace SnapMD.VirtualCare.Sdk.Models
{
    public class UserSessionRes
    {
        public Guid? ApiSessionId { get; set; }
        public string AccessToken { get; set; }
        public DateTimeOffset? Expires { get; set; }
    }
}
