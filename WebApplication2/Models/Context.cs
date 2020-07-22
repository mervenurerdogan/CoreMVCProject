using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-SDCUEKN; database=GITakipDB;integrated security=true;");
        }
        public DbSet<KullaniciTBL> KullaniciTBLs { get; set; }

        public DbSet<GunlukIsTBL> GunlukIsTBLs { get; set; }
        public DbSet<HaftalikIsTBL> HaftalikIsTBLs { get; set; }

        public DbSet<AylikIsTBL> AylikIsTBLs { get; set; }

        public DbSet<NotTBL> NotTBLs { get; set; }

    }
}
