using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.ConnectedCare.ApiModels
{
    public class HospitalInfo
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string HospitalImage { get; set; }
        public string ContactNumber { get; set; }
        public string IsActive { get; set; }

        public string HospitalCode { get; set; }
        public string BrandName { get; set; }
        public string BrandTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int? StateId { get; set; }
        public double? ConsultationCharge { get; set; }
        public string HospitalDomainName { get; set; }
        public string BrandColor { get; set; }
        public string ITDepartmentContactNumber { get; set; }
        public string AppointmentsContactNumber { get; set; }
        public string Locale { get; set; }

        public virtual IEnumerable<HospitalHours> OperatingHours { get; set; }

        public List<string> EnabledModules { get; set; }
    }
}
