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
using System.Collections.Generic;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class BaseProfile
    {
        public string Fname { get; set; }

        public string Lname { get; set; }

        public string Email { get; set; }

        public string PhNumber { get; set; }

        public string CellNumber { get; set; }

        public string TextAlerts { get; set; }

        public string ImgPath { get; set; }

        // ReSharper disable once InconsistentNaming
        public string DOB { get; set; }

        public int? YearPracticing { get; set; }
        
        public string Department { get; set; }
        
        public string MedSpeciality { get; set; }
        
        public string SubSpeciality { get; set; }

        public string MedLicense { get; set; }

        public string StatesLicensed { get; set; }

        public string Schmedicine { get; set; }

        public string PreMedEducation { get; set; }

        public string Internship { get; set; }

        public string Residency { get; set; }

        public string BussAddress { get; set; }

        // ReSharper disable once InconsistentNaming
        public int TimeZoneID { get; set; }

        public string Gender { get; set; }

        public string YearOfStateRegistration { get; set; }

        //Roles collection
        public string Roles { get; set; }

        //Tags collection.
        public string Tags { get; set; }

        public IEnumerable<string> ValidateProfile()
        {
            var errors = new List<string>();
            if (PhNumber.Length > 15 || CellNumber.Length > 15)
            {
                errors.Add("The length of the Phone must be 15 characters or less");
            }

            DateTime dob;
            if (!string.IsNullOrEmpty(DOB) && !DateTime.TryParse(DOB, out dob))
            {
                errors.Add("Invalid DOB. Value: " + DOB);
            }

            return errors;
        }
    }
}