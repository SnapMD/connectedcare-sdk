using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class NewCoUserRequest : PatientRecord
    {
        public string Email { get; set; }

        public int FamilyGroupId { get; set; }

        public int? RelationshipId { get; set; }

        public int? HeightUnitId { get; set; }

        public int? WeightUnitId { get; set; }

        public byte[] Photo { get; set; }
    }
}
