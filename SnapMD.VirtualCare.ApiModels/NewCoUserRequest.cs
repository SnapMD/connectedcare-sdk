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

namespace SnapMD.VirtualCare.ApiModels
{
    public class NewCoUserRequest : PatientRecord
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the family group identifier.
        /// </summary>
        /// <value>
        /// The family group identifier.
        /// </value>
        public int FamilyGroupId { get; set; }

        /// <summary>
        /// Gets or sets the relationship identifier.
        /// </summary>
        /// <value>
        /// The relationship identifier.
        /// </value>
        public int? RelationshipId { get; set; }

        /// <summary>
        /// Gets or sets the height unit identifier.
        /// </summary>
        /// <value>
        /// The height unit identifier.
        /// </value>
        public int? HeightUnitId { get; set; }

        /// <summary>
        /// Gets or sets the weight unit identifier.
        /// </summary>
        /// <value>
        /// The weight unit identifier.
        /// </value>
        public int? WeightUnitId { get; set; }

        /// <summary>
        /// Gets or sets the type of the blood.
        /// </summary>
        /// <value>
        /// The type of the blood.
        /// </value>
        public int? BloodType { get; set; }

        /// <summary>
        /// Gets or sets the color of the eye.
        /// </summary>
        /// <value>
        /// The color of the eye.
        /// </value>
        public int? EyeColor { get; set; }

        /// <summary>
        /// Gets or sets the ethnicity.
        /// </summary>
        /// <value>
        /// The ethnicity.
        /// </value>
        public int? Ethnicity { get; set; }

        /// <summary>
        /// Gets or sets the color of the hair.
        /// </summary>
        /// <value>
        /// The color of the hair.
        /// </value>
        public int? HairColor { get; set; }
    }
}
