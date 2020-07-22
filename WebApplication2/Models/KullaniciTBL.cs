using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class KullaniciTBL
    {
        [Key]
        public int KullaniciID { get; set; }
        public string KullaniciAd { get; set; }
        public string KullaniciSoyad { get; set; }

        public string Mail { get; set; }

        public string Sifre { get; set; }

        public IList<GunlukIsTBL> GunlukIsTBLs { get; set; }

        public IList<AylikIsTBL> AylikIsTBLs { get; set; }

        public IList<HaftalikIsTBL> HaftalikIsTBLs { get; set; }

        public IList<NotTBL> NotTBLs { get; set; }


    }
}
