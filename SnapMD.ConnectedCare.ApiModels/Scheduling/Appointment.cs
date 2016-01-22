using System;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class Appointment
    {
        public Guid AppointmentId { get; set; }
        public int? AvailabilityBlockId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public Guid? OnDemandRequestId { get; set; }
        public Guid IntakeMetadataId { get; set; }
        public AppointmentStatusCode AppointmentStatusCode { get; set; }
        public AppointmentTypeCode AppointmentTypeCode { get; set; }
    }
}
