using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public string birlestir()
        {
            string cumle1 = "Merhaba";
            string cumle2 = "Acunmedya Öğrencileri";
            string cumle3=cumle1 + cumle2;
            return cumle3;
        }
    }
}