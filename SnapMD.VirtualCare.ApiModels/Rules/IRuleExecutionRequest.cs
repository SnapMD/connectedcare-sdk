using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    public interface IRuleExecutionRequest
    {
        RuleCategoryCode Category { get; }

        bool? Debug { get; set; }
    }
}
