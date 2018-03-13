using System;
using System.Text;

namespace SnapMD.VirtualCare.ApiModels
{
    public class AddressLocationObject
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; } 
        public string State { get; set; }
        public string StateCode { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string AddressText { get; set; }
    }
}
