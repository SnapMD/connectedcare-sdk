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
using NUnit.Framework;
using SnapMD.ConnectedCare.Sdk.Test.Properties;

namespace SnapMD.ConnectedCare.Sdk.Test
{
    [TestFixture]
    internal class PaymentApiTests : TestBase
    {
        [Test]
        public void GetCustomer()
        {
            string token;

            var mockWebClient = TokenandWebClientSetup(out token);
            
            mockWebClient.Setup(x => x.DownloadString(new Uri(BaseUri, BaseUri.AbsolutePath + "/hospital/1/payments"))).Returns("{\"PaymentProfile\":[{\"CardNumber\":\"4111111111111111\", \"ExpiryMonth\":\"12\", \"ExpiryYear\":\"2015\" }]}");
            
            var target = new PaymentsApi(Settings.Default.BaseUrl, token, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            var actual = target.GetCustomerProfile(15);

            Assert.False(target.NotFound);
            Assert.False(target.ServerError);
            Assert.NotNull(actual);
            //Assert.AreEqual(actual.PaymentProfiles[0].CardNumber.Value, "XXXX1111");
        }

        [Test]
        public void RegisterProfile()
        {
            var paymentData = new
            {
                FirstName = "FN",
                LastName = "LN",
                Cvv = "123",
                CardNumber = "4111111111111111",
                ExpiryMonth = 12,
                ExpiryYear = DateTime.Today.Year
            };

            string token;

            var mockWebClient = TokenandWebClientSetup(out token);
            mockWebClient.Setup(
                x =>
                    x.UploadString(new Uri(BaseUri, BaseUri.AbsolutePath + @"/patients/payments"), "POST",
                    "{\"FirstName\":\"FN\",\"LastName\":\"LN\",\"Cvv\":\"123\",\"CardNumber\":\"4111111111111111\",\"ExpiryMonth\":12,\"ExpiryYear\":2015}"
                    )).Returns(
                            @"{" +
                            "\"$id\": \"1\"," +
                            "\"success\": true," +
                            "\"data\": {" +
                            "\"$id\": \"2\"," +
                            "\"profileId\": \"31867556\"," +
                            "\"paymentProfileId\": \"32565287\"" +
                            "}," +
                            "\"message\": \"Success\"" +
                            "}"
                );

            var target = new PaymentsApi(Settings.Default.BaseUrl, token, 1, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey,
                mockWebClient.Object);
            var result = target.RegisterProfile(paymentData);

            Assert.Greater((int)result["data"]["profileId"], 1);
        }
    }
}