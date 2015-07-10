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
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Cache;
using System.Collections.Specialized;
using System.ComponentModel;


namespace SnapMD.ConnectedCare.Sdk.Wrappers
{
    public class WebClientWrapper : WebClient, Interfaces.IWebClient
    {
        //public WebClient webClient { get; set; }

        //as ApiCall can call all the necessary function calls, 
        //so should the wrapper be able to do the same.

        public WebClientWrapper() { }

        public WebClientWrapper(WebClient webClient)
        {
            //this.webClient = webClient;
        }

        public new WebHeaderCollection Headers
        {
            get
            {
                return base.Headers;
                //return webClient.Headers;
            }
            set
            {
                base.Headers = value;
                //webClient.Headers = value;
            }
        }

        public new string UploadString(Uri address, string method, string data)
        {
            return base.UploadString(address, method, data);
            //return webClient.UploadString(address, method, data);
        }
    }
}