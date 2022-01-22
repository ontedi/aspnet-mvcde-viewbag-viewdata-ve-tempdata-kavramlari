using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace aspnet_mvcde_viewbag_viewdata_ve_tempdata_kavramlari.Controllers
{
    public class AnasayfaController : Controller
    {
        public IActionResult Index()
        {
            ViewData["AnasayfaViewDataVerisi"] = "ViewData içerisindeki veriler";
            ViewBag.AnasayfaViewBagVerisi = "ViewBag içerisindeki veriler";
            TempData["AnasayfaTempDataVerisi"] = "TempData içerisindeki veriler";
            return View();
        }
    }
}
