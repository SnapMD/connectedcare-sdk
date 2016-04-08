using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    public class RuleResponse : RuleRequest
    {
        public string DetailsJson { get; set; }

        public int? Version { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedByUserId { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? ModifiedByUserId { get; set; }
    }
}
