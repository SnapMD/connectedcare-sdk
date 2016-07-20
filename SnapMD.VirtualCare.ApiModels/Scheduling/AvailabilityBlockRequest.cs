using System;

namespace SnapMD.VirtualCare.ApiModels.Scheduling
{
    /// <summary>
    ///     This payload does not include ID field, creator user, created time, etc.
    /// </summary>
    public class AvailabilityBlockRequest
    {
        /// <summary>
        /// Availability block start time.
        /// </summary>
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Availability block end time.
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Indicates if on demand appointments are allowed.
        /// </summary>
        public bool AllowOnDemandAppt { get; set; }

        /// <summary>
        /// Indicates if provider appointments are allowed.
        /// </summary>
        public bool AllowProviderAppt { get; set; }

        /// <summary>
        /// Indicates if self appointments are allowed.
        /// </summary>
        public bool AllowSelfAppt { get; set; }

        /// <summary>
        /// Is available.
        /// </summary>
        public bool IsAvailable { get; set; }

        /// <summary>
        /// Optimization type code
        /// </summary>
        public AppointmentOptimizationCode OptimizationTypeCode { get; set; }

        /// <summary>
        /// Rule should be set if block is repeating. Rule defines repeating configuration.
        /// </summary>
        public AvailabilityBlockRuleRequest Rule { get; set; }

        /// <summary>
        /// Availability block clinician.
        /// </summary>
        public AvailabilityBlockClinicianRequest Clinician { get; set; }
    }
}
