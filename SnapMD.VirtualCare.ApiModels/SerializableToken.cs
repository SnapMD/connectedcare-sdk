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
// ReSharper disable InconsistentNaming
#pragma warning disable 1591

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// 
    /// </summary>
    public class SerializableToken
    {
        public string access_token { get; set; }

        public DateTimeOffset? expires { get; set; }
    }
}
