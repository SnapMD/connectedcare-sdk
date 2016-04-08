using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    public class RuleSetRequest : RuleRequestBase
    {
        public RuleCategoryCode? RuleCategoryId { get; set; }
    }
}
