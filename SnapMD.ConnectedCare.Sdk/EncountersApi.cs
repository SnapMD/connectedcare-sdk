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

using System.Net;
using SnapMD.ConnectedCare.Sdk.Wrappers;

namespace SnapMD.ConnectedCare.Sdk
{
    public class EncountersApi : ApiCall
    {
        public EncountersApi(string baseUrl, string bearerToken, string developerId, string apiKey)
            : base(baseUrl, new WebClientWrapper(new WebClient()), bearerToken, developerId, apiKey)
        {
        }

        public void UpdateIntakeQuestionnaire(int consultationId, object intakeData)
        {
            var url = string.Format("v2/patients/consultations/{0}/intake", consultationId);
            var result = Put(url, intakeData);
        }
    }
}