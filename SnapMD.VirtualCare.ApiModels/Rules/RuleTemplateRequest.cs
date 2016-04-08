using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    public class RuleTemplateRequest : RuleRequestBase
    {
        public Guid? RuleSetId { get; set; }

        public RuleTypeCode? RuleTypeId { get; set; }

        public int? Priority { get; set; }
    }
}
