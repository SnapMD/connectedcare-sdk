﻿using SnapMD.VirtualCare.ApiModels.Scheduling;
using SnapMD.VirtualCare.Sdk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// DocumentEncounterRequest
    /// </summary>
    public class DocumentEncounterRequest
    {
        /// <summary>
        /// StartTime
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// EndTime
        /// </summary>
        public DateTimeOffset EndTime { get; set; }

        /// <summary>
        /// Gets or sets the patient identifier.
        /// </summary>
        public int PatientId { get; set; }

        /// <summary>
        /// SoapNote
        /// </summary>
        public SoapNote SoapNote { get; set; }

        /// <summary>
        /// Gets or sets the phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets the phonetype
        /// </summary>
        public string PhoneType { get; set; }

        /// <summary>
        /// AdditionalNotes
        /// </summary>
        public string AdditionalNotes { get; set; }

        /// <summary>
        /// ServiceTypeId
        /// </summary>
        public int? ServiceTypeId { get; set; }

        /// <summary>
        /// EncounterTypeCode
        /// </summary>
        public EncounterTypeCode? EncounterTypeCode { get; set; }

        /// <summary>
        /// IntakeConcerns
        /// </summary>
        public List<IntakeConcern>  Concerns { get; set; }

        /// <summary>
        /// MedicalCodeIds - example ids of ICD-10-DX system
        /// </summary>
        public int[] MedicalCodesIds { get; set; }

        /// <summary>
        /// A time interval in an explicitly set timezone.
        /// </summary>
        public ZonedTime ZonedTime { get; set; }
    }
}
