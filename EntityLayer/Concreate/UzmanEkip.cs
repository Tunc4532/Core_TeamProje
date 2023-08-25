using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class UzmanEkip
    {
        [Key]
        public int UzmanEkipID { get; set; }
        public string? Header { get; set; }
        public string? Description { get; set; }
        public string? Tittle { get; set; }
        public int Value { get; set; }
        public string? ImageUrl { get; set; }
    }
}
