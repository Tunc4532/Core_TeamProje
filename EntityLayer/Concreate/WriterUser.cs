using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class WriterUser  : IdentityUser<int>
    {
        public string? Namet { get; set; }
        public string? SurNamet { get; set; }
        public string? ImageUrlt { get; set; }


    }
}
