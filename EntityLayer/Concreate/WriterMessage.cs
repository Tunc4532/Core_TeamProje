using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class WriterMessage
    {
        [Key]
        public int WriterMessageID { get; set; }
        public string? Gonderen { get; set; }
        public string? Alici { get; set; }
        public string? Gonderenadi { get; set; }
        public string? Aliciadi { get; set; }
        public string? Subject { get; set; }
        public string? MessageContent { get; set; }
        public DateTime Date { get; set; }
    }
}
