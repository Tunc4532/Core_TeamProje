using EntityLayer.Concreate; 
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<WriterUser, WriterRole, int>
    {
        //IdentityDbContext<WriterUser,WriterRole,int>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MONSTER2684TUNC\\SQLEXPRESS ; database=DbTeamCv ; integrated security=true");
        }

        public DbSet<BizimleCalisin>? BizimleCalisins { get; set; }
        public DbSet<CevikEkip>? CevikEkips { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<EkipTanitim>? EkipTanitims { get; set; }
        public DbSet<Hizmetler>? Hizmetlers { get; set; }
        public DbSet<Message>? Messages { get; set; }
        public DbSet<OneCikan>? OneCikans { get; set; }
        public DbSet<Portföy>? Portföies { get; set; }
        public DbSet<SocialMedia>? SocialMedias { get; set; }
        public DbSet<Testimonial>? Testimonials { get; set; }
        public DbSet<UVadeliOrtak>? UVadeliOrtaks { get; set; }
        public DbSet<UzmanEkip>? UzmanEkips { get; set; }
        public DbSet<testcok1>? testcok1s { get; set; }
        public DbSet<Announcement>? Announcements { get; set; }
        public DbSet<WriterMessage>? WriterMessages { get; set; }


    }
}
