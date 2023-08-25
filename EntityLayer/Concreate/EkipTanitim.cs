using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class EkipTanitim
    {
        [Key]
        public int EkipTanitimID { get; set; }
        public string? Header { get; set; }
        public string? ImageUrl { get; set; }
        public string? Name { get; set; }
        public string? Meslek { get; set; }

        public string? socialName { get; set; }
        public string? socialUrl { get; set; }
        public string? socialIcon { get; set; }
        public bool socialStatus { get; set; }

        public string? FaceName { get; set; }
        public string? FaceUrl { get; set; }
        public string? FaceIcon { get; set; }

        public string? InsName { get; set; }
        public string? InsUrl { get; set; }
        public string? InsIcon { get; set; }

        public string? LinName { get; set; }
        public string? LinUrl { get; set; }
        public string? LinIcon { get; set; }
    }
}
