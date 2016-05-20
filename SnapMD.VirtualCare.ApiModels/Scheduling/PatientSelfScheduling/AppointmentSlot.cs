using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling.PatientSelfScheduling
{
    /// <summary>
    /// Patient self-scheduling appointment slot.
    /// </summary>
    public class AppointmentSlot
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public AppointmentSlot()
        {
        }

        /// <summary>
        /// Constructor that accepts all fields.
        /// </summary>
        public AppointmentSlot(Guid availabilityBlockId, DateTime from, DateTime to)
        {
            AvailabilityBlockId = availabilityBlockId;
            From = new DateTimeOffset(from, TimeSpan.Zero);
            To = new DateTimeOffset(to, TimeSpan.Zero);
        }

        /// <summary>
        /// Availability block id.
        /// </summary>
        public Guid AvailabilityBlockId { get; set; }

        /// <summary>
        /// Time from.
        /// </summary>
        public DateTimeOffset From { get; set; }

        /// <summary>
        /// Time to.
        /// </summary>
        public DateTimeOffset To { get; set; }
    }
}
