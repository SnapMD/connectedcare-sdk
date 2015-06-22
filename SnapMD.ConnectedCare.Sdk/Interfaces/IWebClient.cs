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
        bool AllowReadStreamBuffering { get; set; }

        bool AllowWriteStreamBuffering { get; set; }

        string BaseAddress { get; set; }

        RequestCachePolicy CachePolicy { get; set; }

        ICredentials Credentials { get; set; }

        Encoding Encoding { get; set; }

        WebHeaderCollection Headers { get; set; }

        bool IsBusy { get; }

        IWebProxy Proxy { get; set; }

        NameValueCollection QueryString { get; set; }

        WebHeaderCollection ResponseHeaders { get; }

        bool UseDefaultCredentials { get; set; }


        event DownloadDataCompletedEventHandler DownloadDataCompleted;

        event AsyncCompletedEventHandler DownloadFileCompleted;

        event DownloadProgressChangedEventHandler DownloadProgressChanged;

        event DownloadStringCompletedEventHandler DownloadStringCompleted;

        event OpenReadCompletedEventHandler OpenReadCompleted;

        event OpenWriteCompletedEventHandler OpenWriteCompleted;

        event UploadDataCompletedEventHandler UploadDataCompleted;

        event UploadFileCompletedEventHandler UploadFileCompleted;

        event UploadProgressChangedEventHandler UploadProgressChanged;

        event UploadStringCompletedEventHandler UploadStringCompleted;

        event UploadValuesCompletedEventHandler UploadValuesCompleted;


        event WriteStreamClosedEventHandler WriteStreamClosed;


        void CancelAsync();

        byte[] DownloadData(string address);

        byte[] DownloadData(Uri address);

        void DownloadDataAsync(Uri address);

        void DownloadDataAsync(Uri address, object userToken);


        Task<byte[]> DownloadDataTaskAsync(string address);


        Task<byte[]> DownloadDataTaskAsync(Uri address);

        void DownloadFile(string address, string fileName);

        void DownloadFile(Uri address, string fileName);

        void DownloadFileAsync(Uri address, string fileName);

        void DownloadFileAsync(Uri address, string fileName, object userToken);

        Task DownloadFileTaskAsync(string address, string fileName);


        Task DownloadFileTaskAsync(Uri address, string fileName);

        string DownloadString(string address);

        string DownloadString(Uri address);

        void DownloadStringAsync(Uri address);

        void DownloadStringAsync(Uri address, object userToken);

        Task<string> DownloadStringTaskAsync(string address);


        Task<string> DownloadStringTaskAsync(Uri address);

        //WebRequest GetWebRequest(Uri address);

        //WebResponse GetWebResponse(WebRequest request);

        WebResponse GetWebResponse(WebRequest request, IAsyncResult result);

        void OnDownloadDataCompleted(DownloadDataCompletedEventArgs e);

        void OnDownloadFileCompleted(AsyncCompletedEventArgs e);

        void OnDownloadProgressChanged(DownloadProgressChangedEventArgs e);

        void OnDownloadStringCompleted(DownloadStringCompletedEventArgs e);

        void OnOpenReadCompleted(OpenReadCompletedEventArgs e);

        void OnOpenWriteCompleted(OpenWriteCompletedEventArgs e);

        void OnUploadDataCompleted(UploadDataCompletedEventArgs e);

        void OnUploadFileCompleted(UploadFileCompletedEventArgs e);

        void OnUploadProgressChanged(UploadProgressChangedEventArgs e);

        void OnUploadStringCompleted(UploadStringCompletedEventArgs e);

        void OnUploadValuesCompleted(UploadValuesCompletedEventArgs e);


        void OnWriteStreamClosed(WriteStreamClosedEventArgs e);

        Stream OpenRead(string address);

        Stream OpenRead(Uri address);

        void OpenReadAsync(Uri address);

        void OpenReadAsync(Uri address, object userToken);

        Task<Stream> OpenReadTaskAsync(string address);

        Task<Stream> OpenReadTaskAsync(Uri address);

        Stream OpenWrite(string address);

        Stream OpenWrite(Uri address);

        Stream OpenWrite(string address, string method);

        Stream OpenWrite(Uri address, string method);

        void OpenWriteAsync(Uri address);

        void OpenWriteAsync(Uri address, string method);

        void OpenWriteAsync(Uri address, string method, object userToken);

        Task<Stream> OpenWriteTaskAsync(string address);

        Task<Stream> OpenWriteTaskAsync(Uri address);

        Task<Stream> OpenWriteTaskAsync(string address, string method);


        Task<Stream> OpenWriteTaskAsync(Uri address, string method);

        byte[] UploadData(string address, byte[] data);

        byte[] UploadData(Uri address, byte[] data);

        byte[] UploadData(string address, string method, byte[] data);

        byte[] UploadData(Uri address, string method, byte[] data);

        void UploadDataAsync(Uri address, byte[] data);

        void UploadDataAsync(Uri address, string method, byte[] data);

        void UploadDataAsync(Uri address, string method, byte[] data, object userToken);


        Task<byte[]> UploadDataTaskAsync(string address, byte[] data);


        Task<byte[]> UploadDataTaskAsync(Uri address, byte[] data);


        Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data);


        Task<byte[]> UploadDataTaskAsync(Uri address, string method, byte[] data);

        byte[] UploadFile(string address, string fileName);

        byte[] UploadFile(Uri address, string fileName);

        byte[] UploadFile(string address, string method, string fileName);

        byte[] UploadFile(Uri address, string method, string fileName);

        void UploadFileAsync(Uri address, string fileName);

        void UploadFileAsync(Uri address, string method, string fileName);

        void UploadFileAsync(Uri address, string method, string fileName, object userToken);

        Task<byte[]> UploadFileTaskAsync(string address, string fileName);

        Task<byte[]> UploadFileTaskAsync(Uri address, string fileName);

        Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName);


        Task<byte[]> UploadFileTaskAsync(Uri address, string method, string fileName);

        string UploadString(string address, string data);

        string UploadString(Uri address, string data);

        string UploadString(string address, string method, string data);

        string UploadString(Uri address, string method, string data);

        void UploadStringAsync(Uri address, string data);

        void UploadStringAsync(Uri address, string method, string data);

        void UploadStringAsync(Uri address, string method, string data, object userToken);


        Task<string> UploadStringTaskAsync(string address, string data);


        Task<string> UploadStringTaskAsync(Uri address, string data);


        Task<string> UploadStringTaskAsync(string address, string method, string data);


        Task<string> UploadStringTaskAsync(Uri address, string method, string data);

        byte[] UploadValues(string address, NameValueCollection data);

        byte[] UploadValues(Uri address, NameValueCollection data);

        byte[] UploadValues(string address, string method, NameValueCollection data);

        byte[] UploadValues(Uri address, string method, NameValueCollection data);

        void UploadValuesAsync(Uri address, NameValueCollection data);

        void UploadValuesAsync(Uri address, string method, NameValueCollection data);

        void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken);

        Task<byte[]> UploadValuesTaskAsync(string address, NameValueCollection data);

        Task<byte[]> UploadValuesTaskAsync(Uri address, NameValueCollection data);

        Task<byte[]> UploadValuesTaskAsync(string address, string method, NameValueCollection data);

        Task<byte[]> UploadValuesTaskAsync(Uri address, string method, NameValueCollection data);
    }
}
