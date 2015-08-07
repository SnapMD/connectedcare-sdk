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
namespace SnapMD.ConnectedCare.ApiModels
{
    /// <summary>
    ///     Represents public information for a clinician that is suitable for patient use.
    /// </summary>
    public class ClinicianProfilesResult
    {
        public string BusinessAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public string Gender { get; set; }

        public int HospitalId { get; set; }

        public string LastName { get; set; }

        public string MedicalLicense { get; set; }

        public string MedicalSpeciality { get; set; }

        public string MedicalSchool { get; set; }

        /// <summary>
        ///     Get Doctor profile image or default one.
        /// </summary>
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

        public string StatesLicenced { get; set; }

        public string SubSpeciality { get; set; }
    }
}
