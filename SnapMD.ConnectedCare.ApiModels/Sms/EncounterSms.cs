using System;

namespace SnapMD.ConnectedCare.ApiModels.Sms
{
    public class EncounterSms
    {
        public int SmsId { get; set; }
        public int ConsultationId { get; set; }
        public ConsultationEvents EventId { get; set; }
        public string MobilePhone { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Sent { get; set; }
        public SmsStatus Status { get; set; }
    }
}
