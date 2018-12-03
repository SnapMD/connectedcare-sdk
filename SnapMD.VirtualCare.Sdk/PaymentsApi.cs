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
using Newtonsoft.Json.Linq;
using SnapMD.VirtualCare.ApiModels;
using SnapMD.VirtualCare.ApiModels.Payments;
using SnapMD.VirtualCare.Sdk.Models;
using SnapMD.VirtualCare.Sdk.Interfaces;

namespace SnapMD.VirtualCare.Sdk
{
    /// <summary>
    /// Represents Payments Api.
    /// </summary>
    public class PaymentsApi : ApiCall
    {
        /// <summary>
        /// Constructor of PaymentsApi.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="baseUrl"></param>
        /// <param name="bearerToken"></param>
        /// <param name="developerId"></param>
        /// <param name="hospitalId"></param>
        /// <param name="webClient"></param>
        public PaymentsApi(string baseUrl, string bearerToken, int hospitalId, string developerId, string apiKey, IWebClient webClient)
            : base(baseUrl, webClient, bearerToken, developerId, apiKey)
        {
            HospitalId = hospitalId;
        }

        /// <summary>
        /// Constructor of PaymentsApi.
        /// </summary>
        /// <param name="baseUrl"></param>
        /// <param name="hospitalId"></param>
        /// <param name="webClient"></param>
        public PaymentsApi(string baseUrl, int hospitalId, IWebClient webClient)
            : base(baseUrl, webClient)
        {
            HospitalId = hospitalId;
        }

        /// <summary>
        ///     Get or Set HospitalId .
        /// </summary>
        /// <value>
        ///    HospitalId
        /// </value> 
        public int HospitalId { get; private set; }

        /// <summary>
        ///     Get the Customer Profile .
        /// </summary>
        /// <param name="patientUserId"></param>
        public ApiResponseV2<CimCustomer> GetCustomerProfile(int? patientUserId)
        {
            //fixed to match the unit test
            var result = MakeCall<ApiResponseV2<CimCustomer>>(string.Format("v2/patients/{0}/payments", patientUserId));
            return result;
        }

        /// <summary>
        ///     Get the Register Profile .
        /// </summary>
        /// <param name="paymentData"></param>
        public ApiResponseV2<PaymentProfilePostResult> RegisterProfile(object paymentData)
        {
            var result = Post<ApiResponseV2<PaymentProfilePostResult>>(string.Format("v2/patients/payments"), paymentData);
            return result;
        }
        /// <summary>
        ///     Get the Get Payment Status .
        /// </summary>
        /// <param name="consultationId"></param>
        public ApiResponseV2<bool> GetPaymentStatus(int consultationId)
        {
            var result = MakeCall<ApiResponseV2<bool>>(string.Format("v2/patients/copay/{0}/paymentstatus", consultationId));
            return result;
        }
    }
}