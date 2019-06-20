using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

namespace SnapMD.VirtualCare.ApiModels.FileSharing
{
    /// <summary>
    /// Legacy file model
    /// </summary>
    public class FileModel
    {
        private const string _dateTimeFormat = "MM/dd/yyyy h:mm tt";

        private static readonly ReadOnlyCollection<object> _emptyList = new ReadOnlyCollection<object>(new object[0]);

        /// <summary>
        /// Name of creator
        /// </summary>
        public string CreatedBy { get; set; }
        public string CreatedDate => DateCreated?.ToString(_dateTimeFormat, CultureInfo.InvariantCulture);
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
        public string Id { get; set; }
        public bool IsAttachedToConsultation { get; set; }
        public bool IsFolder { get; } = false;
        public bool IsReadable { get; set; }
        public bool IsRemovable { get; set; }
        public bool IsSharedFolder { get; } = false;
        public bool IsWritable { get; set; }
        public string Md5 { get; set; }
        public string ModifiedDate => DateModified?.ToString(_dateTimeFormat, CultureInfo.InvariantCulture);
        public string Name { get; set; }
        public string ParentDuid { get; set; }

        public long Size { get; set; }

        /// <summary>
        /// Mime type
        /// </summary>
        public string Type { get; set; }

        public string DownloadLink { get; set; }

        /// <summary>
        /// Legacy property for acting user id
        /// </summary>
        public int UserId { get; set; }

    }
}
