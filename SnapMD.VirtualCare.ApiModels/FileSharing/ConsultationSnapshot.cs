using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnapMD.VirtualCare.ApiModels.FileSharing
{
    public class ConsultationSnapshot
    {
        public FileModel File { get; set; }
        public string ThumbnailDataUrl { get; set; }
        public string DataUrl { get; set; }
    }
}
