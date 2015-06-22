using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.ConnectedCare.Sdk
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

        protected override System.Net.WebRequest GetWebRequest(Uri address)
        {
            return base.GetWebRequest(address);
        }

        protected override System.Net.WebResponse GetWebResponse(System.Net.WebRequest request)
        {
            //System.Net.WebResponse response = base.GetWebResponse(request);
            return ReturnOnResponse(request);
        }

        protected override System.Net.WebResponse GetWebResponse(System.Net.WebRequest request, IAsyncResult result)
        {
            return base.GetWebResponse(request, result);
        }
    }
}
