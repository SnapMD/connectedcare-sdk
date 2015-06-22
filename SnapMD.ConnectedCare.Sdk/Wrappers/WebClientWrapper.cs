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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Cache;
using System.Collections.Specialized;
using System.ComponentModel;
using Moq;


namespace SnapMD.ConnectedCare.Sdk.Wrappers
{
    public class WebClientWrapper : WebClient, Interfaces.IWebClient
    {
        public WebClient webClient { get; set; }

        //as ApiCall can call all the necessary function calls, 
        //so should the wrapper be able to do the same.

        public WebClientWrapper(WebClient webClient)
        {
            this.webClient = webClient;
        }

        public new WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
        {
            return base.GetWebResponse(request, result);
        }


        public new void OnDownloadDataCompleted(System.Net.DownloadDataCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnDownloadFileCompleted(System.ComponentModel.AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnDownloadProgressChanged(System.Net.DownloadProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnDownloadStringCompleted(System.Net.DownloadStringCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnOpenReadCompleted(System.Net.OpenReadCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnOpenWriteCompleted(System.Net.OpenWriteCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnUploadDataCompleted(System.Net.UploadDataCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnUploadFileCompleted(System.Net.UploadFileCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnUploadProgressChanged(System.Net.UploadProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnUploadStringCompleted(System.Net.UploadStringCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnUploadValuesCompleted(System.Net.UploadValuesCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public new void OnWriteStreamClosed(System.Net.WriteStreamClosedEventArgs e)
        {
            throw new NotImplementedException();
        }


        public bool AllowReadStreamBuffering
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool AllowWriteStreamBuffering
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public string BaseAddress
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public RequestCachePolicy CachePolicy
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public ICredentials Credentials
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Encoding Encoding
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public WebHeaderCollection Headers
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

        public bool IsBusy
        {
            get { throw new NotImplementedException(); }
        }

        public IWebProxy Proxy
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public NameValueCollection QueryString
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public WebHeaderCollection ResponseHeaders
        {
            get { throw new NotImplementedException(); }
        }

        public bool UseDefaultCredentials
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        public event DownloadDataCompletedEventHandler DownloadDataCompleted;

        public event AsyncCompletedEventHandler DownloadFileCompleted;

        public event DownloadProgressChangedEventHandler DownloadProgressChanged;

        public event DownloadStringCompletedEventHandler DownloadStringCompleted;

        public event OpenReadCompletedEventHandler OpenReadCompleted;

        public event OpenWriteCompletedEventHandler OpenWriteCompleted;

        public event UploadDataCompletedEventHandler UploadDataCompleted;

        public event UploadFileCompletedEventHandler UploadFileCompleted;

        public event UploadProgressChangedEventHandler UploadProgressChanged;

        public event UploadStringCompletedEventHandler UploadStringCompleted;

        public event UploadValuesCompletedEventHandler UploadValuesCompleted;

        public event WriteStreamClosedEventHandler WriteStreamClosed;


        public void CancelAsync()
        {
            throw new NotImplementedException();
        }


        public byte[] DownloadData(string address)
        {
            throw new NotImplementedException();
        }

        public byte[] DownloadData(Uri address)
        {
            throw new NotImplementedException();
        }

        public void DownloadDataAsync(Uri address)
        {
            throw new NotImplementedException();
        }

        public void DownloadDataAsync(Uri address, object userToken)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> DownloadDataTaskAsync(string address)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> DownloadDataTaskAsync(Uri address)
        {
            throw new NotImplementedException();
        }

        public void DownloadFile(string address, string fileName)
        {
            throw new NotImplementedException();
        }

        public void DownloadFile(Uri address, string fileName)
        {
            throw new NotImplementedException();
        }

        public void DownloadFileAsync(Uri address, string fileName)
        {
            throw new NotImplementedException();
        }

        public void DownloadFileAsync(Uri address, string fileName, object userToken)
        {
            throw new NotImplementedException();
        }

        public Task DownloadFileTaskAsync(string address, string fileName)
        {
            throw new NotImplementedException();
        }

        public Task DownloadFileTaskAsync(Uri address, string fileName)
        {
            throw new NotImplementedException();
        }

        public string DownloadString(string address)
        {
            throw new NotImplementedException();
        }

        public string DownloadString(Uri address)
        {
            return base.DownloadString(address);
        }

        public void DownloadStringAsync(Uri address)
        {
            throw new NotImplementedException();
        }

        public void DownloadStringAsync(Uri address, object userToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> DownloadStringTaskAsync(string address)
        {
            throw new NotImplementedException();
        }

        public Task<string> DownloadStringTaskAsync(Uri address)
        {
            throw new NotImplementedException();
        }


        public Stream OpenRead(string address)
        {
            throw new NotImplementedException();
        }

        public Stream OpenRead(Uri address)
        {
            throw new NotImplementedException();
        }

        public void OpenReadAsync(Uri address)
        {
            throw new NotImplementedException();
        }

        public void OpenReadAsync(Uri address, object userToken)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> OpenReadTaskAsync(string address)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> OpenReadTaskAsync(Uri address)
        {
            throw new NotImplementedException();
        }

        public Stream OpenWrite(string address)
        {
            throw new NotImplementedException();
        }

        public Stream OpenWrite(Uri address)
        {
            throw new NotImplementedException();
        }

        public Stream OpenWrite(string address, string method)
        {
            throw new NotImplementedException();
        }

        public Stream OpenWrite(Uri address, string method)
        {
            throw new NotImplementedException();
        }

        public void OpenWriteAsync(Uri address)
        {
            throw new NotImplementedException();
        }

        public void OpenWriteAsync(Uri address, string method)
        {
            throw new NotImplementedException();
        }

        public void OpenWriteAsync(Uri address, string method, object userToken)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> OpenWriteTaskAsync(string address)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> OpenWriteTaskAsync(Uri address)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> OpenWriteTaskAsync(string address, string method)
        {
            throw new NotImplementedException();
        }

        public Task<Stream> OpenWriteTaskAsync(Uri address, string method)
        {
            throw new NotImplementedException();
        }


        public byte[] UploadData(string address, byte[] data)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadData(Uri address, byte[] data)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadData(string address, string method, byte[] data)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadData(Uri address, string method, byte[] data)
        {
            throw new NotImplementedException();
        }

        public void UploadDataAsync(Uri address, byte[] data)
        {
            throw new NotImplementedException();
        }

        public void UploadDataAsync(Uri address, string method, byte[] data)
        {
            throw new NotImplementedException();
        }

        public void UploadDataAsync(Uri address, string method, byte[] data, object userToken)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadDataTaskAsync(string address, byte[] data)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadDataTaskAsync(Uri address, byte[] data)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadDataTaskAsync(string address, string method, byte[] data)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadDataTaskAsync(Uri address, string method, byte[] data)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadFile(string address, string fileName)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadFile(Uri address, string fileName)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadFile(string address, string method, string fileName)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadFile(Uri address, string method, string fileName)
        {
            throw new NotImplementedException();
        }

        public void UploadFileAsync(Uri address, string fileName)
        {
            throw new NotImplementedException();
        }

        public void UploadFileAsync(Uri address, string method, string fileName)
        {
            throw new NotImplementedException();
        }

        public void UploadFileAsync(Uri address, string method, string fileName, object userToken)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadFileTaskAsync(string address, string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadFileTaskAsync(Uri address, string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadFileTaskAsync(string address, string method, string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadFileTaskAsync(Uri address, string method, string fileName)
        {
            throw new NotImplementedException();
        }

        public string UploadString(string address, string data)
        {
            throw new NotImplementedException();
        }

        public string UploadString(Uri address, string data)
        {
            throw new NotImplementedException();
        }

        public string UploadString(string address, string method, string data)
        {
            throw new NotImplementedException();
        }

        public string UploadString(Uri address, string method, string data)
        {
            return base.UploadString(address, method, data);
        }

        public void UploadStringAsync(Uri address, string data)
        {
            throw new NotImplementedException();
        }

        public void UploadStringAsync(Uri address, string method, string data)
        {
            throw new NotImplementedException();
        }

        public void UploadStringAsync(Uri address, string method, string data, object userToken)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadStringTaskAsync(string address, string data)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadStringTaskAsync(Uri address, string data)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadStringTaskAsync(string address, string method, string data)
        {
            throw new NotImplementedException();
        }

        public Task<string> UploadStringTaskAsync(Uri address, string method, string data)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadValues(string address, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadValues(Uri address, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadValues(string address, string method, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

        public byte[] UploadValues(Uri address, string method, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

        public void UploadValuesAsync(Uri address, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

        public void UploadValuesAsync(Uri address, string method, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

        public void UploadValuesAsync(Uri address, string method, NameValueCollection data, object userToken)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadValuesTaskAsync(string address, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadValuesTaskAsync(Uri address, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadValuesTaskAsync(string address, string method, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

        public Task<byte[]> UploadValuesTaskAsync(Uri address, string method, NameValueCollection data)
        {
            throw new NotImplementedException();
        }

    }
}