using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class NotAlController : Controller
    {

        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.NotTBLs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniNot()
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
        public IActionResult YeniNot(NotTBL n)
        {
            var d1 = c.KullaniciTBLs.Where(x => x.KullaniciID == n.Kullanici.KullaniciID).FirstOrDefault();
            n.Kullanici = d1;

            c.NotTBLs.Add(n);
            c.SaveChanges();


            return RedirectToAction("Index");


        }

        public IActionResult NotSil(int id)
        {
            var nots = c.NotTBLs.Find(id);
            c.NotTBLs.Remove(nots);
            c.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult NotGetir(int id)
        {

            var nots = c.NotTBLs.SingleOrDefault(x => x.NotID == id);

            List<SelectListItem> kuldeger = (from i in c.KullaniciTBLs.ToList()
                                             select new SelectListItem
                                             {

                                                 Text = i.KullaniciAd + "" + i.KullaniciSoyad,
                                                 Value = i.KullaniciID.ToString()
                                             }

                                          ).ToList();
            ViewBag.kuldgr = kuldeger;
            return View("NotGetir",nots);
        }

        [HttpPost]

        public IActionResult NotGuncelle(NotTBL n)
        {
            var nots = c.NotTBLs.SingleOrDefault(x => x.NotID == n.NotID);

            n.NotIcerik = nots.NotIcerik;
            n.NotBasligi = n.NotBasligi;
            n.NotAlinmaTarih = nots.NotAlinmaTarih;
       

            var d1 = c.KullaniciTBLs.Where(x => x.KullaniciID == n.Kullanici.KullaniciID).FirstOrDefault();
            n.Kullanici = d1;
            c.SaveChanges();


            return RedirectToAction("Index");
        }



        }
    }
