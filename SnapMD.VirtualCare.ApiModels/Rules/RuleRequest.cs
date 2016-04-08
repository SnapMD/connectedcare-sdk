using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.Rules
{
    public abstract class RuleRequestBase
    {
        public Guid? Id { get; set; }

        public string Description { get; set; }

        public string SatisfiedMessage { get; set; }

        public string UnsatisfiedMessage { get; set; }

        public GlobalStatusCode? StatusCode { get; set; }
    }

    public class RuleRequest : RuleRequestBase
    {
        public Guid? RuleTemplateId { get; set; }

        public int? ProviderId { get; set; }

        public RuleLogicTypeCode? ConditionTypeId { get; set; }

        public RuleConditionSource? ConditionSource { get; set; }

        public int? Sequence { get; set; }
    }
}
