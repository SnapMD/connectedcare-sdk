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

using System.Collections.Generic;
using System.Linq;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.Sdk.Interfaces;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    /// This API returns the data required for populating the intake portion of Appointments and Encounters APIs.
    /// </summary>
    /// <seealso cref="SnapMD.VirtualCare.Sdk.ApiCall" />
    public class IntakeApi : ApiCall
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntakeApi" /> class.
        /// </summary>
        /// <param name="baseUrl">The base URL.</param>
        /// <param name="bearerToken">The bearer token.</param>
        /// <param name="developerId">The developer identifier.</param>
        /// <param name="apiKey">The API key.</param>
        /// <param name="webClient">The web client.</param>
        public IntakeApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
        }

        /// <summary>
        /// Gets the codesets for hospital intake form. The returned values can be used for populating the intake APIs when
        /// creating a new appointment.
        /// <see cref="AppointmentsApi" />  <seealso cref="EncountersApi" />
        /// </summary>
        /// <param name="hospitalId">The hospital identifier.</param>
        /// <returns></returns>
        public List<CodeSetResponse> GetIntakeItems(int hospitalId)
        {
            var result =
                MakeCall(string.Format("v2/codesets?hospitalId={0}&fields={1}",
                    hospitalId,
                    "medicalconditions,medications,medicationallergies,consultprimaryconcerns,consultsecondaryconcerns"));

            return result.ToObject<ApiResponseV2<CodeSetResponse>>().Data.ToList();
        }
    }
}
