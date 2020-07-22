using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HesapController : Controller
    {

        Context c = new Context();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("id").HasValue)
            {
                return Redirect("/Anasayfa/Index");

            }
            return View();
        }

        public IActionResult GirisYap( string Mail,string Sifre)
        {
            var user = c.KullaniciTBLs.FirstOrDefault(x => x.Mail.Equals(Mail) && x.Sifre.Equals(Sifre));
            if(user != null)
            {
                HttpContext.Session.SetInt32("id", user.KullaniciID);
                HttpContext.Session.SetString("fullname", user.KullaniciAd+ " " +user.KullaniciSoyad);

               return Redirect("/Anasayfa/Index");
            }
            return Redirect("Index");


        }
        public IActionResult KayitOl()
        {
            if (HttpContext.Session.GetInt32("id").HasValue)
            {
                return Redirect("/Anasayfa/Index");

            }

            return View();
        }

        public async Task<IActionResult> Register(KullaniciTBL kullanici)
        {
            await c.AddAsync(kullanici);
            await c.SaveChangesAsync();

            return Redirect("Index");
        }

        public IActionResult CikisYap()
        {
            HttpContext.Session.Clear();
            return Redirect("Index");
        }
    }
}
