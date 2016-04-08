using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    public class SubjectAddressRuleRequest : RuleRequest
    {
        public string Country { get; set; }

        public string State { get; set; }

        public string County { get; set; }

        public string City { get; set; }

        public List<string> PostalCodes { get; set; }
    }
}
