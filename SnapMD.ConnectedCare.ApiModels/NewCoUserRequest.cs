using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class NewCoUserRequest : PatientRecord
    {
        public int? RelationshipId { get; set; }

        public byte[] Photo { get; set; }
    }
}
