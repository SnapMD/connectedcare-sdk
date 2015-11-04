namespace SnapMD.ConnectedCare.ApiModels
{

    /// <summary>
    /// Wraps a consultation ID in a response for scheduled consultation POST APIs.
    /// </summary>
    public class ScheduledConsultationResult
    {
        /// <summary>
        /// The ID of the newly-created consultation.
        /// </summary>
        public int ConsultationId { get; set; }
    }
}
