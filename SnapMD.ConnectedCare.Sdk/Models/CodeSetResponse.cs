using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.ConnectedCare.Sdk.Models
{
    public class CodeSetResponse
    {
        public string Name { get; set; }
        public int HospitalId { get; set; }
        public IList<CodeItem> Codes { get; set; }

        public class CodeItem
        {
            public int CodeId { get; set; }
            public string Text { get; set; }
            public int DisplayOrder { get; set; }
        }
    }
}
