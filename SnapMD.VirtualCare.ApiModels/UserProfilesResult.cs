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

using System;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     Represents information for a clinician or patient that is suitable for patient use.
    /// </summary>
    public class UserProfilesResult
    {
        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender: "M" for Male, "F" for Female.
        /// </value>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the profile identifier.
        /// </summary>
        /// <value>
        /// The profile identifier.
        /// </value>
        public int ProfileId { get; set; }

        /// <summary>
        /// Gets the profile image.
        /// </summary>
        /// <value>
        /// The profile image.
        /// </value>
        public string ProfileImage
        {
            get
            {
                if (!string.IsNullOrEmpty(ProfileImagePath))
                {
                    return ProfileImagePath;
                }

                return Gender == "F" ? "/images/Doctor-Female.gif" : "/images/Doctor-Male.gif";
            }
        }

        /// <summary>
        /// Gets or sets the profile image path.
        /// </summary>
        /// <value>
        /// The profile image path.
        /// </value>
        public string ProfileImagePath { get; set; }

        /// <summary>
        /// Gets or sets the organization identifier.
        /// </summary>
        /// <value>
        /// The organization identifier.
        /// </value>
        public int? OrganizationId { get; set; }

        /// <summary>
        /// Gets or sets the location identifier.
        /// </summary>
        /// <value>
        /// The location identifier.
        /// </value>
        public int? LocationId { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>
        /// The time zone.
        /// </value>
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the time zone identifier.
        /// </summary>
        /// <value>
        /// The time zone identifier.
        /// </value>
        public int? TimeZoneId { get; set; }

        /// <summary>
        /// Gets or sets time zone string identifier. Example: 'Eastern Standard Time'.
        /// </summary>
        public string TimeZoneSystemId { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the dob.
        /// </summary>
        /// <value>
        /// The dob.
        /// </value>
        public DateTime? Dob { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public string Weight { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        /// <value>
        /// The height.
        /// </value>
        public string Height { get; set; }

        /// <summary>
        /// Gets or sets the home phone.
        /// </summary>
        /// <value>
        /// The home phone.
        /// </value>
        public string HomePhone { get; set; }

        /// <summary>
        /// Gets or sets the mobile phone.
        /// </summary>
        /// <value>
        /// The mobile phone.
        /// </value>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Gets or sets the color of the hair.
        /// </summary>
        /// <value>
        /// The color of the hair.
        /// </value>
        public int? HairColor { get; set; }

        /// <summary>
        /// Gets or sets the color of the eye.
        /// </summary>
        /// <value>
        /// The color of the eye.
        /// </value>
        public int? EyeColor { get; set; }

        /// <summary>
        /// Gets or sets the type of the blood.
        /// </summary>
        /// <value>
        /// The type of the blood.
        /// </value>
        public int? BloodType { get; set; }

        /// <summary>
        /// Gets or sets the ethnicity.
        /// </summary>
        /// <value>
        /// The ethnicity.
        /// </value>
        public int? Ethnicity { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has required fields.
        /// </summary>
        /// <value>
        /// <c>true</c> if this instance has required fields; otherwise, <c>false</c>.
        /// </value>
        public bool HasRequiredFields
        {
            //address isn't required for dependents
            // taking this out: !string.IsNullOrWhiteSpace(Address)
            get
            {
                if (!string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName) &&
                    Dob.HasValue && !string.IsNullOrWhiteSpace(Gender) &&
                    !string.IsNullOrWhiteSpace(MobilePhone) && 
                    !string.IsNullOrWhiteSpace(TimeZone))
                {
                    return true;
                }
                return false;
            }
        }

        /// <summary>
        /// The person identifier of the user.
        /// </summary>
        public Guid? PersonId { get; set; }

        /// <summary>
        /// Is user dependent.
        /// </summary>
        public bool IsDependent { get; set; }

        /// <summary>
        /// Guardian full name (for dependent patients).
        /// </summary>
        public string GuardianName { get; set; }

        /// <summary>
        /// Guardian user id (for dependent patients).
        /// </summary>
        public int? GuardianUserId { get; set; }

        /// <summary>
        /// User role description.
        /// </summary>
        public string UserRoleDescription { get; set; }
    }
}
