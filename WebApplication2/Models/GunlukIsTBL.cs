using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class GunlukIsTBL
    {

        [Key]
        public int GunlukID { get; set; }

        public string IsBasligi { get; set; }

        public string Aciklama { get; set; }

        public DateTime BaslamaTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }

        public int KullaniciID { get; set; }

        public KullaniciTBL KullaniciTBL { get; set; }

    }
}
