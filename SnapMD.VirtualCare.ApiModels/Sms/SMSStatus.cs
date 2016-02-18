namespace SnapMD.VirtualCare.ApiModels.Sms
{
    public enum SmsStatus
    {
        New = 0,
        Pending = 1,
        Sent = 2,
        Failed = 3,
        Invalid = 4,
        ConsultationError = 5,
        TemplateError = 6,
        NoTextAlerts = 7
    }
}
