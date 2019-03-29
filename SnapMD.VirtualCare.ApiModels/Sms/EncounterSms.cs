using System;

namespace SnapMD.VirtualCare.ApiModels.Sms
{
    /// <summary>
    /// Represents the Encounter Sms.
    /// </summary>
    public class EncounterSms
    {
        /// <summary>
        ///  Get or Set Sms Id
        /// </summary>
        /// <value> SmsId</value>
        public int SmsId { get; set; }
        /// <summary>
        ///  Get or Set Consultation Id
        /// </summary>
        /// <value> ConsultationId</value>
        public int ConsultationId { get; set; }
        /// <summary>
        ///  Get or Set ConsultationEvents
        /// </summary>
        /// <value> ConsultationEvents</value>
        public ConsultationEvents EventId { get; set; }
        /// <summary>
        ///  Get or Set Mobile Phone
        /// </summary>
        /// <value> Mobile Phone</value>
        public string MobilePhone { get; set; }
        /// <summary>
        ///  Get or Set Created
        /// </summary>
        /// <value> Created</value>
        public DateTimeOffset Created { get; set; }
        /// <summary>
        ///  Get or Set Sent date time
        /// </summary>
        /// <value> Sent date time</value>
        public DateTimeOffset? Sent { get; set; }
        /// <summary>
        ///  Get or Set the sms Status
        /// </summary>
        /// <value> 
        /// New = 0,Pending = 1,Sent = 2, Failed = 3,Invalid = 4,
        /// ConsultationError = 5,TemplateError = 6,NoTextAlerts = 7
        /// </value>
        public SmsStatus Status { get; set; }
    }
}
