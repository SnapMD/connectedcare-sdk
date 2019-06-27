#region Copyright
//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
#endregion

using SnapMD.VirtualCare.ApiModels.Enums;
using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Record describing one patient medication allergy
    /// </summary>
    public class PatientAllergyItem
    {
        /// <summary>
        ///  Gets or sets the Asserter PersonId.
        /// </summary>
        [XmlElement, DefaultValue(null)]
        public Guid? AsserterPersonId { get; set; }

        /// <summary>
        ///  Gets or sets the Asserter FullName.
        /// </summary>
        ///  /// <value>
        ///   AsserterFullName
        /// </value>
        [XmlElement(IsNullable = false)]
        public string AsserterFullName { get; set; }

        /// <summary>
        ///  Gets or sets the RecorderPersonId.
        /// </summary>
        ///  /// <value>
        ///   Person Id
        /// </value>
        [XmlElement, DefaultValue(null)]
        public Guid? RecorderPersonId { get; set; }


        /// <summary>
        ///  Gets or sets the Recorder FullName.
        /// </summary>
        ///  /// <value>
        ///   RecorderFullName
        /// </value>
        [XmlElement(IsNullable = false)]
        public string RecorderFullName { get; set; }

        /// <summary>
        ///  Gets or sets the Asserted Date.
        /// </summary>
        ///  /// <value>
        ///   AssertedDate
        /// </value>
        [XmlElement, DefaultValue(null)]
        public DateTime? AssertedDate { get; set; }

        /// <summary>
        ///  Gets or sets the RecordedDate.
        /// </summary>
        ///  /// <value>
        ///   RecordedDate
        /// </value>
        [XmlElement, DefaultValue(null)]
        public DateTime? RecordedDate { get; set; }


        /// <summary>
        ///  Gets or sets the OnsetDate.
        /// </summary>
        ///  /// <value>
        ///   OnsetDate
        /// </value>
        [XmlElement, DefaultValue(null)]
        public DateTime? OnsetDate { get; set; }

        /// <summary>
        ///  Gets or sets the LastOccurrenceDate.
        /// </summary>
        ///  /// <value>
        ///   LastOccurrenceDate
        /// </value>
        [XmlElement, DefaultValue(null)]
        public DateTime? LastOccurrenceDate { get; set; }

        /// <summary>
        ///  Gets or sets the CriticalityId.
        /// </summary>
        ///  /// <value>
        ///   CriticalityId
        /// </value>
        [XmlElement("Criticality"), DefaultValue(null)]
        public AllergyCriticalityCode? CriticalityId { get; set; }

        /// <summary>
        ///  Gets or sets the TypeId.
        /// </summary>
        ///  /// <value>
        ///   TypeId
        /// </value>
        [XmlElement("Type"), DefaultValue(null)]
        public AllergyTypeCode? TypeId { get; set; }

        /// <summary>
        ///  Gets or sets the CategoryId.
        /// </summary>
        ///  /// <value>
        ///   CategoryId
        /// </value>
        [XmlElement("Category"), DefaultValue(null)]
        public AllergyCategoryCode? CategoryId { get; set; }

        /// <summary>
        ///  Gets or sets the Code.
        /// </summary>
        ///  /// <value>
        ///   Code
        /// </value>
        [XmlAttribute]
        public int Code { get; set; }

        /// <summary>
        ///  Gets or sets the Description.
        /// </summary>
        ///  /// <value>
        ///   Description
        /// </value>
        [XmlElement(IsNullable = false)]
        public string Description { get; set; }

        /// <summary>
        ///  Gets or sets the Notes.
        /// </summary>
        ///  /// <value>
        ///   Notes
        /// </value>
        [XmlElement(IsNullable = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Represent the Should Serialize Asserter PersonId.
        /// </summary>
        ///  /// <value>
        ///   ShouldSerializeAsserterPersonId
        /// </value>
        public bool ShouldSerializeAsserterPersonId() { return AsserterPersonId.HasValue; }
        /// <summary>
        /// Represent the  Should Serialize Recorder PersonId
        ///  /// <value>
        ///  Should Serialize Recorder PersonId
        /// </value>
        public bool ShouldSerializeRecorderPersonId() { return RecorderPersonId.HasValue; }
        /// <summary>
        /// Represent the Should Should Serialize Asserted Date
        ///  /// <value>
        ///  Should Serialize sserted Date
        /// </value>
        public bool ShouldSerializeAssertedDate() { return AssertedDate.HasValue; }
        /// <summary>
        /// Represent the Should Serialize Recorde Date
        ///  /// <value>
        ///  ShouldSerializeRecordedDate
        /// </value>
        public bool ShouldSerializeRecordedDate() { return RecordedDate.HasValue; }
        /// <summary>
        /// Represent the ShouldSerializeOnsetDate
        ///  /// <value>
        ///  ShouldSerializeOnsetDate
        /// </value>
        public bool ShouldSerializeOnsetDate() { return OnsetDate.HasValue; }
        /// <summary>
        /// Represent the ShouldSerializeLastOccurrenceDate
        ///  /// <value>
        ///  ShouldSerializeLastOccurrenceDate
        /// </value>
        public bool ShouldSerializeLastOccurrenceDate() { return LastOccurrenceDate.HasValue; }
        /// <summary>
        /// Represent the ShouldSerializeCriticalityId
        ///  /// <value>
        ///  ShouldSerializeCriticalityId
        /// </value>
        public bool ShouldSerializeCriticalityId() { return CriticalityId.HasValue; }
        /// <summary>
        /// Represent the ShouldSerializeTypeId
        ///  /// <value>
        ///  ShouldSerializeTypeId
        /// </value>
        public bool ShouldSerializeTypeId() { return TypeId.HasValue; }
        /// <summary>
        /// Represent the ShouldSerializeCategoryId
        ///  /// <value>
        ///  ShouldSerializeCategoryId
        /// </value>
        public bool ShouldSerializeCategoryId() { return CategoryId.HasValue; }
    }

    /// <summary>
    /// Record describing one patient medication allergy.
    /// It's used during old consultation metadata deserialization from XML ONLY to distinguish from new metadata.
    /// </summary>
    public class LegacyPatientAllergyItem: PatientAllergyItem
    {

    }
}
