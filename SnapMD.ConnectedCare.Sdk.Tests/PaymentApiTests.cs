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

using System;
using System.Linq;
using NUnit.Framework;
using SnapMD.ConnectedCare.Sdk.Tests.Properties;

namespace SnapMD.ConnectedCare.Sdk.Tests
{
    [TestFixture]
    internal class PaymentApiTests : TestBase
    {
        [Test]
        public void GetCustomer()
        {
            string token;

            var mockWebClient = TokenandWebClientSetup(out token);
            
            //var mockWebClient = TokenandWebClientSetupRemoteCall(out token);
            mockWebClient.Setup(x => x.DownloadString(new Uri(BaseUri, "v2/patients/15/payments")))
                .Returns("{\"$id\": \"1\",\"data\": [{\"$id\": \"2\", \"billingAddress\":\"555 Pine St.\", \"description\":\"\", \"Email\":\"abc@abc.com\"}]}");
            
            var target = new PaymentsApi(Settings.Default.BaseUrl, token, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            var actual = target.GetCustomerProfile(15);

            Assert.False(target.NotFound);
            Assert.False(target.ServerError);
            Assert.NotNull(actual.Data.FirstOrDefault());
            //Assert.AreEqual(actual.PaymentProfiles[0].CardNumber.Value, "XXXX1111");
        }

        [Test]
        public void RegisterProfile()
        {
            var paymentData = new
            {
                CardNumber = "4111111111111111",
                ExpiryMonth = 12,
                ExpiryYear = DateTime.Today.Year
            };

            string token;

            var mockWebClient = TokenandWebClientSetup(out token);
            mockWebClient.Setup(
                x =>
                    x.UploadString(new Uri(BaseUri, @"v2/patients/payments"), "POST",
                        "{\"CardNumber\":\"4111111111111111\",\"ExpiryMonth\":12,\"ExpiryYear\":2015}")).Returns(
                            @"{" +
                            "\"$id\": \"1\"," +
                            "\"success\": true," +
                            "\"data\": [{" +
                            "\"$id\": \"2\"," +
                            "\"customerProfileID\": \"31867556\"," +
                            "\"paymentProfileId\": \"32565287\"" +
                            "}]," +
                            "\"message\": \"Success\"" +
                            "}"
                );

            var target = new PaymentsApi(Settings.Default.BaseUrl, token, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey,
                mockWebClient.Object);
            var result = target.RegisterProfile(paymentData);

            Assert.Greater(Convert.ToInt32(result.Data.First().CustomerProfileId), 1);
        }
    }
}