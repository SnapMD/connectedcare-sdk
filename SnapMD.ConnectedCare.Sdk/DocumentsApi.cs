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
using SnapMD.ConnectedCare.ApiModels;
using SnapMD.ConnectedCare.Sdk.Interfaces;
using SnapMD.ConnectedCare.Sdk.Models;

namespace SnapMD.ConnectedCare.Sdk
{
    public class DocumentsApi : ApiCall
    {
        public DocumentsApi(string baseUrl, string developerId, string apiKey, IWebClient client)
            : base(baseUrl, client, null, developerId, apiKey)
        {
            RequiresAuthentication = false;
        }

        public ApiResponseV2<DocumentsResponse> GetDocument(DocumentTypeCode documentType, int hospitalId)
        {
            if (documentType == 0)
            {
                throw new ArgumentException("The documentType value '0' is not appropriate for this method.");
            }

            // v2/publicdocuments?documentType=1&hospitalId=126
            var o = MakeCall<ApiResponseV2<DocumentsResponse>>("v2/publicdocuments?documentType={0}&hospitalId={1}", (int)documentType, hospitalId);
            return o;
        }
    }

}