using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Hizmetler
    {
        [Key]
        public int HizmetlerID { get; set; }
        public string? Header { get; set; }
        public string? Description { get; set; }
        public string? IconUrl { get; set; }
        public string? Tittle { get; set; }
        public string? DescriptionTwo { get; set; }
    }
}
