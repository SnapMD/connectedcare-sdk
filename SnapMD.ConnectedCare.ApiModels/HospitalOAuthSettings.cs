using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class HospitalOAuthSettings
    {
        /// <summary>
        /// how the hospital wants their onboarded customer accounts' passwords will be treated
        /// </summary>
        public enum CustomerPasswordMode
        {
            Undefined,
            No,
            Yes,
            RequiredOrOnly
        }

        public HospitalOAuthSettings()
        {
            CustomerPasswords = CustomerPasswordMode.Undefined;
        }

        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string Url { get; set; }
        public string Callback { get; set; }
        public CustomerPasswordMode CustomerPasswords { get; set; }
        public string LoginUrl { get; set; }
        public string ReturnUrl { get; set; }
    }
}
