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
using System;
using System.Net;

namespace SnapMD.VirtualCare.Sdk.Wrappers
{
    /// <summary>
    /// As ApiCall can call all the necessary function calls,
    /// so should the wrapper be able to do the same.
    /// </summary>
    /// <seealso cref="System.Net.WebClient" />
    /// <seealso cref="SnapMD.VirtualCare.Sdk.Interfaces.IWebClient" />
    public class WebClientWrapper : WebClient, Interfaces.IWebClient
    {
        public WebClientWrapper() { }

        public WebClientWrapper(WebClient webClient)
        {
        }

        public new WebHeaderCollection Headers
        {
            get
            {
                return base.Headers;
            }
            set
            {
                base.Headers = value;
            }
        }

        public new string UploadString(Uri address, string method, string data)
        {
            return base.UploadString(address, method, data);
        }
    }
}