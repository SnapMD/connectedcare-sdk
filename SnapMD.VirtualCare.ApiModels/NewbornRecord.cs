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
    /// <summary>
    ///     Patient newbord record.
    /// </summary>
    public class NewbornRecord
    {
        /// <summary>
        ///     Discharged with mother.
        /// </summary>
        public string DischargedWithMother { get; set; }

        /// <summary>
        ///     Full term.
        /// </summary>
        public string FullTerm { get; set; }

        /// <summary>
        ///     Patient age under one year.
        /// </summary>
        public string PatientAgeUnderOneYear { get; set; }

        /// <summary>
        ///     Vaccinations current.
        /// </summary>
        public string VaccinationsCurrent { get; set; }

        /// <summary>
        ///     Vaginal birth.
        /// </summary>
        public string VaginalBirth { get; set; }
    }
}
