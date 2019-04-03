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

using System.Collections.Generic;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///   Encapsulate the Code Set Response
    /// </summary>
    public class CodeSetResponse
    {
        /// <summary>
        /// Get or set the Name of the code set
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Get or set the Hospital Id
        /// </summary>
        public int HospitalId { get; set; }
        /// <summary>
        /// Get or set the Codes
        /// </summary>
        public IList<CodeItem> Codes { get; set; }

        /// <summary>
        ///   Encapsulate the Code Item
        /// </summary>
        public class CodeItem
        {
            /// <summary>
            /// Get or set the Code Id
            /// </summary>
            /// <value> Code Id </value>
            public int CodeId { get; set; }
            /// <summary>
            /// Get or set the Name of the code 
            /// </summary>
            /// <value> Code Name </value>
            public string Text { get; set; }
            /// <summary>
            /// Get or set the Display Order 
            /// </summary>
            /// <value> Display Order </value>
            public int DisplayOrder { get; set; }
        }
    }
}
