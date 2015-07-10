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

using System.Collections.Generic;
using System.Linq;

namespace SnapMD.ConnectedCare.Sdk.Models
{
    public class ApiResponse : ApiResponse<object>
    {
    }

    public class ApiResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
    }

    /// <summary>
    /// Wraps the response based on our documented API.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiResponseV2<T>
    {
        /// <summary>
        /// The payload being returned to the requestor.
        /// </summary>
        public IEnumerable<T> Data { get; set; }

        /// <summary>
        /// Used in paginated requests to indicate the number of records available. This feature is not enabled for all calls,
        /// so please contact developer support for more information.
        /// </summary>
        public int? Total { get; set; }

        /// <summary>
        /// Allows shorthand construction of the wrapper.
        /// </summary>
        /// <param name="data"></param>
        public ApiResponseV2(T data)
        {
            Data = new[] { data };
        }

        /// <summary>
        /// Allows shorthand for IEnumerable types
        /// </summary>
        /// <param name="data"></param>
        public ApiResponseV2(IEnumerable<T> data)
        {
            Data = data;
            Total = data.Count();
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ApiResponseV2()
        {
        }
    }
}