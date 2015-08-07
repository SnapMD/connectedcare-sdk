#region Copyright
//    Copyright 2015 SnapMD, Inc.
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

namespace SnapMD.ConnectedCare.ApiModels
{
    /// <summary>
    ///     Represents public information for a clinician that is suitable for patient use.
    /// </summary>
    public class UserProfilesResult
    {
        public string FirstName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string Gender { get; set; }

        public string LastName { get; set; }

        public int ProfileId { get; set; }

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

        public string ProfileImagePath { get; set; }

        public string TimeZone { get; set; }

        public int TimeZoneId { get; set; }

        public int UserId { get; set; }

        public DateTime? Dob { get; set; }

        public string Address { get; set; }

        public string Weight { get; set; }

        public string Height { get; set; }

        public string MobilePhone { get; set; }

        public int? Enthicity { get; set; }

        public bool HasRequiredFields
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName) &&
                    Dob.HasValue && !string.IsNullOrWhiteSpace(Gender) &&
                    Enthicity.HasValue && !string.IsNullOrWhiteSpace(Height) &&
                    !string.IsNullOrWhiteSpace(Weight) &&
                    !string.IsNullOrWhiteSpace(MobilePhone) && !string.IsNullOrWhiteSpace(Address) &&
                    !string.IsNullOrWhiteSpace(TimeZone))
                {
                    return true;
                }
                return false;
            }
        }
    }
}
