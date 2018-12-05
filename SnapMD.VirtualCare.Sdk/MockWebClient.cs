using System;

namespace SnapMD.VirtualCare.Sdk
{
    public delegate System.Net.WebResponse WebResponseChores(System.Net.WebRequest request);

    public class MockWebClient : System.Net.WebClient
    {
        public MockWebClient() : base() { }

        public MockWebClient(WebResponseChores ReturnOnResponse)
            : base()
        {
            this.ReturnOnResponse = ReturnOnResponse;
        }

        public WebResponseChores ReturnOnResponse { get; set; }

        /// <summary>
        ///  Get the Web Request.
        /// </summary>
        /// <param name="address"></param>
        protected override System.Net.WebRequest GetWebRequest(Uri address)
        {
            return base.GetWebRequest(address);
        }

        /// <summary>
        ///  Get the Web Response.
        /// </summary>
        /// <param name="request"></param>
        protected override System.Net.WebResponse GetWebResponse(System.Net.WebRequest request)
        {
            return ReturnOnResponse(request);
        }

        /// <summary>
        ///  Get the Web Response.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="result"></param>
        protected override System.Net.WebResponse GetWebResponse(System.Net.WebRequest request, IAsyncResult result)
        {
            return base.GetWebResponse(request, result);
        }
    }
}
