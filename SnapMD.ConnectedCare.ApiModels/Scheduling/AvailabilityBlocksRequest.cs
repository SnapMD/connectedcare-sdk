using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.ConnectedCare.ApiModels.Scheduling
{
    public class AvailabilityBlocksRequest
    {
        public int[] clinicianIds;
        public DateTime? startDate;
        public DateTime? endDate;
    }
}
