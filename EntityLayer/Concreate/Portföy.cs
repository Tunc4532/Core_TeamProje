using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Portföy
    {
        [Key]
        public int PortföyID { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public string? ProjectUrl { get; set; }
        public string? ImageUrlTwo { get; set; }
    }
}
