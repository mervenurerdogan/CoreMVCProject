using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AylikController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.AylikIsTBLs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniAylik()
        {
            List<SelectListItem> kuldeger = (from i in c.KullaniciTBLs.ToList()
                                             select new SelectListItem
                                             {

                                                 Text = i.KullaniciAd + "" + i.KullaniciSoyad,
                                                 Value = i.KullaniciID.ToString()
                                             }

                                          ).ToList();
            ViewBag.kuldgr = kuldeger;

            return View();
        }
        [HttpPost]

        public IActionResult YeniAylik(AylikIsTBL a)
        {

            var d1 = c.KullaniciTBLs.Where(x => x.KullaniciID == a.KullaniciTBL.KullaniciID).FirstOrDefault();
            a.KullaniciTBL = d1;

            c.AylikIsTBLs.Add(a);
            c.SaveChanges();


            return RedirectToAction("Index");

        }

        public IActionResult AylikSil(int id)
        {
            var aylik = c.AylikIsTBLs.Find(id);
            c.AylikIsTBLs.Remove(aylik);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

       [HttpGet]

       public IActionResult AylikGetir(int id)
        {

            var aylik = c.AylikIsTBLs.SingleOrDefault(x => x.AylikID == id);

            List<SelectListItem> kuldeger = (from i in c.KullaniciTBLs.ToList()
                                             select new SelectListItem
                                             {

                                                 Text = i.KullaniciAd + "" + i.KullaniciSoyad,
                                                 Value = i.KullaniciID.ToString()
                                             }

                                          ).ToList();
            ViewBag.kuldgr = kuldeger;

            return View("AylikGetir", aylik);


            
        }

        [HttpPost]

        public IActionResult AylikGuncelle(AylikIsTBL a)
        {

            var aylik = c.AylikIsTBLs.SingleOrDefault(x => x.AylikID == a.AylikID);
            aylik.IsBasligi = a.IsBasligi;
            aylik.Aciklama = a.Aciklama;
            aylik.BaslamaTarihi = a.BaslamaTarihi;
            aylik.BitisTarihi = a.BitisTarihi;

            var d1 = c.KullaniciTBLs.Where(x => x.KullaniciID == a.KullaniciTBL.KullaniciID).FirstOrDefault();
            a.KullaniciTBL = d1;

            c.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
