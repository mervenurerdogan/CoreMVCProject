using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class NotTBL
    {

        [Key]
        public int NotID { get; set; }

        public string NotBasligi { get; set; }

        public DateTime NotAlinmaTarih { get; set; }
        public string NotIcerik { get; set; }
        public int KullaniciID { get; set; }

        public KullaniciTBL Kullanici { get; set; }
    }
}
