using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Filters;

namespace WebApplication2.Controllers
{
    [UserFiltre]
    public class AnasayfaController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
    }
}
