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
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Cache;
using System.Collections.Specialized;
using System.ComponentModel;

namespace SnapMD.ConnectedCare.Sdk.Interfaces
{
    public interface IWebClient
    {
        WebHeaderCollection Headers { get; set; }

        string UploadString(Uri address, string method, string data);

        string DownloadString(string address);

        string DownloadString(Uri address);

        //WebResponse GetWebResponse(WebRequest request, IAsyncResult result);
    }
}
