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
using System.Text;
using System.IO;
using Moq;
using NUnit.Framework;
using SnapMD.ConnectedCare.Sdk;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Tests;
using SnapMD.ConnectedCare.Sdk.Tests.Properties;

namespace SnapMD.ConnectedCare.Sdk.Tests
{
    [TestFixture]
    public class IntakeApiTests : TestBase
    {
        [Test]
        public void GetIntakes()
        {
            string token;

            Mock<IWebClient> mockWebClient = TokenandWebClientSetup(out token);

            mockWebClient.Setup(x => x.DownloadString(new Uri(BaseUri, @"v2/codesets?hospitalId=1&fields=medicalconditions,medications,medicationallergies,consultprimaryconcerns,consultsecondaryconcerns"))).Returns(@"{
  ""$id"": ""1"",
  ""data"": [
    {
      ""$id"": ""2"",
      ""name"": ""Medical Conditions"",
      ""hospitalId"": 1,
      ""codes"": [
        {
          ""$id"": ""3"",
          ""codeId"": 12,
          ""text"": ""ADD orADHD"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""4"",
          ""codeId"": 13,
          ""text"": ""Allergies"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""5"",
          ""codeId"": 14,
          ""text"": ""Asthma"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""6"",
          ""codeId"": 15,
          ""text"": ""Cancer"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""7"",
          ""codeId"": 16,
          ""text"": ""Diabetes"",
          ""displayOrder"": 0
        }
      ]
    },
    {
      ""$id"": ""8"",
      ""name"": ""Medications"",
      ""hospitalId"": 1,
      ""codes"": [
        {
          ""$id"": ""9"",
          ""codeId"": 22,
          ""text"": ""Allergy Medications"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""10"",
          ""codeId"": 23,
          ""text"": ""Antibiotics"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""11"",
          ""codeId"": 24,
          ""text"": ""Asthma Medications"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""12"",
          ""codeId"": 25,
          ""text"": ""Pain Medications"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""13"",
          ""codeId"": 26,
          ""text"": ""Mental Health Medications"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""14"",
          ""codeId"": 27,
          ""text"": ""Seizure Medications"",
          ""displayOrder"": 0
        }
      ]
    },
    {
      ""$id"": ""15"",
      ""name"": ""Medication Allergies"",
      ""hospitalId"": 1,
      ""codes"": [
        {
          ""$id"": ""16"",
          ""codeId"": 17,
          ""text"": ""Allergy Medication"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""17"",
          ""codeId"": 18,
          ""text"": ""Antibiotics"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""18"",
          ""codeId"": 19,
          ""text"": ""Anticonvulsants"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""19"",
          ""codeId"": 20,
          ""text"": ""Asprin"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""20"",
          ""codeId"": 21,
          ""text"": ""Insulin"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""21"",
          ""codeId"": 3641,
          ""text"": ""Other"",
          ""displayOrder"": 0
        }
      ]
    },
    {
      ""$id"": ""22"",
      ""name"": ""Patients Primary Concern"",
      ""hospitalId"": 1,
      ""codes"": [
        {
          ""$id"": ""23"",
          ""codeId"": 81,
          ""text"": ""Fever (100+)"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""24"",
          ""codeId"": 82,
          ""text"": ""Cough"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""25"",
          ""codeId"": 83,
          ""text"": ""Vomiting"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""26"",
          ""codeId"": 84,
          ""text"": ""Pink Eye"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""27"",
          ""codeId"": 85,
          ""text"": ""Stomach and Abdominal Pain"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""28"",
          ""codeId"": 86,
          ""text"": ""Cramps and Spasms"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""29"",
          ""codeId"": 87,
          ""text"": ""Diarrhea or Constipation"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""30"",
          ""codeId"": 88,
          ""text"": ""Skin Rash"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""31"",
          ""codeId"": 89,
          ""text"": ""Earache or Ear Infection"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""32"",
          ""codeId"": 90,
          ""text"": ""Sore Throat"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""33"",
          ""codeId"": 91,
          ""text"": ""Injury: Head, Neck, Face"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""34"",
          ""codeId"": 92,
          ""text"": ""Headache"",
          ""displayOrder"": 0
        },
        {
          ""$id"": ""35"",
          ""codeId"": 93,
          ""text"": ""Other (provide details below)"",
          ""displayOrder"": 0
        }
      ]
    },
    {
      ""$id"": ""36"",
      ""name"": ""Patients Secondary Concern"",
      ""hospitalId"": 1,
      ""codes"": []
    }
  ],
  ""total"": 5
}");

            var api = new IntakeApi(Settings.Default.BaseUrl, token, Settings.Default.ApiDeveloperId, Settings.Default.ApiKey, mockWebClient.Object);
            var val = api.GetIntakeItems(1);

            Assert.NotNull(val);
            Assert.Greater(val[0].Codes.Count, 0);
        }
    }
}