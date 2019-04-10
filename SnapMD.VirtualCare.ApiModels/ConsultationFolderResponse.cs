using SnapMD.VirtualCare.ApiModels.FileSharing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels
{
    public class ConsultationFolderResponse
    {
        public IList<ConsultationSnapshot> Snapshots { get; set; }
        public IList<FileModel> Files { get; set; }
    }
}
