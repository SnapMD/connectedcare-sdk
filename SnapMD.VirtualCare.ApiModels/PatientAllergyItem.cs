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
    /// Record about 1 patient medication allergy
    /// </summary>
    public class PatientAllergyItem
    {
        [XmlElement, DefaultValue(null)]
        public Guid? AsserterPersonId { get; set; }

        [XmlElement(IsNullable = false)]
        public string AsserterFullName { get; set; }

        [XmlElement, DefaultValue(null)]
        public Guid? RecorderPersonId { get; set; }

        [XmlElement(IsNullable = false)]
        public string RecorderFullName { get; set; }

        [XmlElement, DefaultValue(null)]
        public DateTime? AssertedDate { get; set; }

        [XmlElement, DefaultValue(null)]
        public DateTime? RecordedDate { get; set; }

        [XmlElement, DefaultValue(null)]
        public DateTime? OnsetDate { get; set; }

        [XmlElement, DefaultValue(null)]
        public DateTime? LastOccurrenceDate { get; set; }

        [XmlElement("Criticality"), DefaultValue(null)]
        public AllergyCriticalityCode? CriticalityId { get; set; }

        [XmlElement("Type"), DefaultValue(null)]
        public AllergyTypeCode? TypeId { get; set; }

        [XmlElement("Category"), DefaultValue(null)]
        public AllergyCategoryCode? CategoryId { get; set; }

        [XmlAttribute]
        public int Code { get; set; }

        [XmlElement(IsNullable = false)]
        public string Description { get; set; }

        [XmlElement(IsNullable = false)]
        public string Notes { get; set; }

        public bool ShouldSerializeAsserterPersonId() { return AsserterPersonId.HasValue; }
        public bool ShouldSerializeRecorderPersonId() { return RecorderPersonId.HasValue; }
        public bool ShouldSerializeAssertedDate() { return AssertedDate.HasValue; }
        public bool ShouldSerializeRecordedDate() { return RecordedDate.HasValue; }
        public bool ShouldSerializeOnsetDate() { return OnsetDate.HasValue; }
        public bool ShouldSerializeLastOccurrenceDate() { return LastOccurrenceDate.HasValue; }
        public bool ShouldSerializeCriticalityId() { return CriticalityId.HasValue; }
        public bool ShouldSerializeTypeId() { return TypeId.HasValue; }
        public bool ShouldSerializeCategoryId() { return CategoryId.HasValue; }
    }
}
