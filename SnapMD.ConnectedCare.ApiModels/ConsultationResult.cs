using System;
using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class ConsultationResult
    {
        public ResponseObservableItem AssignedDoctor { get; set; }

        public string ConferenceKey { get; set; }

        public ConsultationStatusCode ConsultationStatus { get; set; }

        public int HospitalId { get; set; }

        public int Id { get; set; }

        public string IsScheduled { get; set; }

        public string Note { get; set; }

        public ResponseObservableItem Patient { get; set; }

        public string PhoneNumber { get; set; }

        public ResponseObservableItem ResponsibleUser { get; set; }

        public DateTime? Time { get; set; }
    }
}
