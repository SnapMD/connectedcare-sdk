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

using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using SnapMD.ConnectedCare.ApiModels;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.Sdk
{
    public class IntakeApi: ApiCall
    {
        public IntakeApi(string baseUrl, string bearerToken, string developerId, string apiKey, IWebClient WebClient)
            : base(baseUrl, WebClient, bearerToken, developerId, apiKey)
        {
            
        }

        public List<CodeSetResponse> GetIntakeItems(int HospitalId)
        {
            var result = MakeCall(string.Format("v2/codesets?hospitalId={0}&fields={1}",HospitalId,"medicalconditions,medications,medicationallergies,consultprimaryconcerns,consultsecondaryconcerns"));

            return result.ToObject<ApiResponseV2<CodeSetResponse>>().Data.ToList();

            //while (dataEnumerator.MoveNext())
            //    if (dataEnumerator.Current != null)
            //        return dataEnumerator.Current.;

            //return null;

        }
    }
}
