using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    public class SubjectDistanceRuleRequest : RuleRequest
    {
        public GeoCoordinate Center { get; set; }

        public decimal? Distance { get; set; }

        public GeoDistanceUnit? DistanceUnit { get; set; }
    }
}
