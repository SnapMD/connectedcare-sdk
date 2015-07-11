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
using Newtonsoft.Json.Linq;
using SnapMD.ConnectedCare.Sdk.Models;
using SnapMD.ConnectedCare.Sdk.Interfaces;

namespace SnapMD.ConnectedCare.Sdk
{
    public class PaymentsApi : ApiCall
    {
        public PaymentsApi(string baseUrl, string bearerToken, int hospitalId, string developerId, string apiKey, IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
            HospitalId = hospitalId;
        }

        public PaymentsApi(string baseUrl, int hospitalId, IWebClient webClient)
            : base(baseUrl, webClient)
        {
            HospitalId = hospitalId;
        }

        public int HospitalId { get; private set; }

        public JObject GetCustomerProfile(int userId)
        {
            //API looks so strange 
            var result = MakeCall(string.Format("hospital/{0}/payments", HospitalId));
            return result;
        }

        public JObject RegisterProfile(object paymentData)
        {
            //hospital/{hospitalId}/payments/{userId}
            var result = Post(string.Format("patients/payments"), paymentData);
            return result;
        }

        public ApiResponse GetPaymentStatus(int consultationId)
        {
            var result = MakeCall<ApiResponse>(string.Format("patients/copay/{0}/paymentstatus", consultationId));
            return result;
        }
    }
}