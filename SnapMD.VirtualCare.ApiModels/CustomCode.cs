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

using System.Xml.Serialization;

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    ///     FHIR HL7 Coding concept, custom code.
    /// </summary>
    public struct CustomCode : ICustomCode
    {
        /// <summary>
        ///     Initialize custom code from code and description.
        /// </summary>
        public CustomCode(int code, string description) : this()
        {
            Code = code;
            Description = description;
        }

        /// <summary>
        ///     Initialize custom code from string line.
        /// </summary>
        public CustomCode(string singleLine = null) : this()
        {
            Parse(null, singleLine);
        }

        /// <summary>
        ///     Initialize custom code from either code and string line or just string line.
        /// </summary>
        public CustomCode(string scode, string descr) : this()
        {
            Parse(scode, descr);
        }

        private void Parse(string scode, string descr)
        {
            int code = 0;
            if (scode != null)
                int.TryParse(scode, out code);
            if (!string.IsNullOrWhiteSpace(descr) && code == 0)
            {
                var splitChar = 'ξ';
                if (descr.IndexOf(splitChar) == -1)
                    splitChar = '?';

                var tokens = descr.Split(splitChar);
                if (tokens.Length > 1 && int.TryParse(tokens[0], out code))
                    descr = tokens[1];
            }
            Code = code;
            Description = descr;
        }

        /// <summary>
        ///     Code number.
        /// </summary>
        [XmlAttribute("Code")]
        public int Code { get; set; }

        /// <summary>
        ///     Code description.
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        ///     Example: 82?SampleText
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var description = Description ?? string.Empty;
            return Code > 0 ? $"{Code}?{Description}" : description;
        }
    }

    /// <summary>
    ///     FHIR HL7 Coding concept, custom code.
    /// </summary>
    public interface ICustomCode
    {
        /// <summary>
        ///     Code number.
        /// </summary>
        int Code { get; set; }

        /// <summary>
        ///     Code description.
        /// </summary>
        string Description { get; set; }
    }
}
