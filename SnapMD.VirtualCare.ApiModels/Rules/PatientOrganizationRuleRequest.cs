using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    public class PatientOrganizationRuleRequest : RuleRequest
    {
        public int? OrganizationId { get; set; }

        public int? LocationId { get; set; }
    }
}
