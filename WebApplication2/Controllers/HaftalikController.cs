using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HaftalikController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.HaftalikIsTBLs.ToList();
            return View(degerler);
        }

        [HttpGet]
         public IActionResult HaftalikEkle()
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
        public IActionResult HaftalikEkle(HaftalikIsTBL h)
        {

            var d1 = c.KullaniciTBLs.Where(x => x.KullaniciID == h.KullaniciTBL.KullaniciID).FirstOrDefault();
            h.KullaniciTBL = d1;

            c.HaftalikIsTBLs.Add(h);
            c.SaveChanges();

            return RedirectToAction("Index");
        }


        public IActionResult HaftalikSil(int id)
        {
            var haftalik = c.HaftalikIsTBLs.Find(id);
            c.HaftalikIsTBLs.Remove(haftalik);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult HaftalikGetir(int id)
        {
            var hafta = c.HaftalikIsTBLs.SingleOrDefault(x => x.HaftlikID == id);

            List<SelectListItem> kuldeger = (from i in c.KullaniciTBLs.ToList()
                                             select new SelectListItem
                                             {

                                                 Text = i.KullaniciAd + "" + i.KullaniciSoyad,
                                                 Value = i.KullaniciID.ToString()
                                             }

                                          ).ToList();
            ViewBag.kuldgr = kuldeger;

            return View("HaftalikGetir", hafta);


            
        }

        [HttpPost]
        public IActionResult HaftalikGuncelle(HaftalikIsTBL h)
        {

            var hafta = c.HaftalikIsTBLs.SingleOrDefault(x => x.HaftlikID == h.HaftlikID);
            hafta.IsBasligi = h.IsBasligi;
            hafta.Aciklama = h.Aciklama;
            hafta.BaslamaTarihi = h.BaslamaTarihi;
            hafta.BitisTarihi = h.BitisTarihi;

            var d1 = c.KullaniciTBLs.Where(x => x.KullaniciID == h.KullaniciTBL.KullaniciID).FirstOrDefault();
            h.KullaniciTBL = d1;

            c.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
