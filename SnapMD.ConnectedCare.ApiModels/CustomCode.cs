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
using System.Xml.Serialization;

namespace SnapMD.ConnectedCare.ApiModels
{
    public struct CustomCode : ICustomCode
    {
        public CustomCode(int code, string description) : this()
        {
            Code = code;
            Description = description;
        }

        public CustomCode(string singleLine = null) : this()
        {
            Description = "";


            if (!string.IsNullOrWhiteSpace(singleLine))
            {
                var splitChar = 'ξ';
                if (singleLine.IndexOf(splitChar) == -1)
                {
                    splitChar = '?';
                }

                var tokens = singleLine.Split(splitChar);
                if (tokens.Length > 1)
                {
                    var temp = 0;
                    Int32.TryParse(tokens[0], out temp);
                    Code = temp;
                    Description = tokens[1];
                }
                else
                {
                    Description = singleLine;
                }
            }
        }

        [XmlAttribute("Code")]
        public int Code { get; set; }

        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        ///     Example: 82?SampleText
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var description = Description ?? "";
            return Code > 0 ? string.Format("{0}?{1}", Code, Description) : description;
        }
    }

    public interface ICustomCode
    {
        int Code { get; set; }

        string Description { get; set; }
    }
}
