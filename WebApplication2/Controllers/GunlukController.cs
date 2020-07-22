using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class GunlukController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.GunlukIsTBLs.ToList();

            return View(degerler);
        }
        [HttpGet]
        public IActionResult YeniGunluk()
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
        public IActionResult YeniGunluk(GunlukIsTBL g)
        {
            var d1 = c.KullaniciTBLs.Where(x => x.KullaniciID == g.KullaniciTBL.KullaniciID).FirstOrDefault();
            g.KullaniciTBL = d1;

            c.GunlukIsTBLs.Add(g);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

     
     
        public IActionResult GunlukSil(int id)
        {
            var gun = c.GunlukIsTBLs.Find(id);
            c.GunlukIsTBLs.Remove(gun);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

      [HttpGet]
        public IActionResult GunIsGetir(int id)
        {

            var gun = c.GunlukIsTBLs.SingleOrDefault(x => x.GunlukID == id);

            List<SelectListItem> kuldeger = (from i in c.KullaniciTBLs.ToList()
                                             select new SelectListItem
                                             {

                                                 Text = i.KullaniciAd + "" + i.KullaniciSoyad,
                                                 Value = i.KullaniciID.ToString()
                                             }

                                          ).ToList();
            ViewBag.kuldgr = kuldeger;

            return View("GunIsGetir", gun);

        }


        [HttpPost]
        public IActionResult GunlukIsGuncelle(GunlukIsTBL g)
        {


            var gunluk = c.GunlukIsTBLs.SingleOrDefault(x => x.GunlukID == g.GunlukID);
            gunluk.IsBasligi = g.IsBasligi;
            gunluk.Aciklama = g.Aciklama;
            gunluk.BaslamaTarihi = g.BaslamaTarihi;
            gunluk.BitisTarihi = g.BitisTarihi;

            var d1 = c.KullaniciTBLs.Where(x => x.KullaniciID == g.KullaniciTBL.KullaniciID).FirstOrDefault();
            g.KullaniciTBL = d1;

            c.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}
