using System;
using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels.Scheduling.PatientSelfScheduling
{
    /// <summary>
    /// Self-scheduling clinicians search results and grouping totals.
    /// </summary>
    public class SelfSchedulingClinicianSearchResult
    {
        /// <summary>
        /// Found clinicians.
        /// </summary>
        public List<SelfSchedulingClinician> Clinicians { get; set; }

        /// <summary>
        /// Start time of the next available appointment slot (after the date specified in a filter) or null
        /// </summary>
        public DateTimeOffset? NextSlotStart { get; set; }

        /// <summary>
        /// Simple totals (map properties to counts).
        /// </summary>
        public Dictionary<string, int> Totals { get; set; }

        /// <summary>
        /// Grouped totals. Map properties to arrays of counters for differemt values.
        /// </summary>
        public Dictionary<string, Counter[]> Counters { get; set; }

        /// <summary>
        /// Counters for values of some property.
        /// </summary>
        public class Counter
        {
            /// <summary>
            /// Value of the property. 
            /// May be string, enum, table row id (int?, Guid?). Type depends on the property.
            /// </summary>
            public object Value { get; set; }

            /// <summary>
            /// Display name for the value.
            /// </summary>
            public string Display { get; set; }

            /// <summary>
            /// Counter for the value.
            /// </summary>
            public int Count { get; set; }
        }
    }
}
