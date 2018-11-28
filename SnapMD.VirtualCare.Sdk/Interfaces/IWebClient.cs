//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//    http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
using System;
using System.Net;

namespace SnapMD.VirtualCare.Sdk.Interfaces
{
    /// <summary>
    /// Return person api.
    /// </summary>
    public interface IWebClient
    {
        /// <summary>
        ///  Web Header collection
        /// </summary>
        WebHeaderCollection Headers { get; set; }

        /// <summary>
        ///  Upload string
        /// </summary>
        string UploadString(Uri address, string method, string data);

        /// <summary>
        ///  Download string address wise
        /// </summary>
        string DownloadString(string address);

        /// <summary>
        ///  Download string uri wise
        /// </summary>
        string DownloadString(Uri address);
    }
}
