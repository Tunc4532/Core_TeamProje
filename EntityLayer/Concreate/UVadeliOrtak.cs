using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class UVadeliOrtak
    {
        [Key]
        public int UVadeliOrtakID { get; set; }
        public string? Header { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? BaslıkAd { get; set; }
        public string? BaslıkAciklama { get; set; }
    }
}
