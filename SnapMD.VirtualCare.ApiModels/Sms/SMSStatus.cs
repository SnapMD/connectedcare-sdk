namespace SnapMD.VirtualCare.ApiModels.Sms
{
    /// <summary>
    /// Represents the Sms Status.
    /// </summary>
    public enum SmsStatus
    {
        /// <summary>
        ///  SmsStatus code New.
        /// </summary>
        /// <value>Code is 0</value>
        New = 0,
        /// <summary>
        ///  SmsStatus code Pending.
        /// </summary>
        /// <value>Code is 1</value>
        Pending = 1,
        /// <summary>
        ///  SmsStatus code Sent.
        /// </summary>
        /// <value>Code is 2</value>
        Sent = 2,
        /// <summary>
        ///  SmsStatus code Failed.
        /// </summary>
        /// <value>code is 3</value>
        Failed = 3,
        /// <summary>
        ///  SmsStatus code Invalid.
        /// </summary>
        /// <value>code is 4</value>
        Invalid = 4,
        /// <summary>
        ///  SmsStatus code ConsultationError.
        /// </summary>
        /// <value>code is 5</value>
        ConsultationError = 5,
        /// <summary>
        ///  SmsStatus code TemplateError.
        /// </summary>
        /// <value>code is 6</value>
        TemplateError = 6,
        /// <summary>
        ///  SmsStatus code NoTextAlerts.
        /// </summary>
        /// <value>code is 7</value>
        NoTextAlerts = 7
    }
}
