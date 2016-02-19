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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace SnapMD.VirtualCare.ApiModels
{
    public class HospitalInfo : ProviderBase
    {
        public string City { get; set; }

        public string ContactPerson { get; set; }

        [JsonConverter(typeof (StringEnumConverter))]
        public CustomerSsoType CustomerSso { get; set; }

        public string CustomerSsoLinkText { get; set; }

        public List<string> EnabledModules { get; set; }

        public int HospitalId { get; set; }

        public string HospitalName { get; set; }

        public string HospitalImage { get; set; }
        public string IsActive { get; set; }

        public virtual IEnumerable<HospitalHours> OperatingHours { get; set; }

        public string HospitalDomainName { get; set; }
        public string PatientConsultEndUrl { get; set; }
        
        public string PatientLogin { get; set; }

        public IDictionary<string, string> Settings { get; set; }
    }
}
