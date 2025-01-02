using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class ContactController : Controller
    {
        DbDominicPortfolioEntities1 db = new DbDominicPortfolioEntities1 ();
        // GET: Contact
        public ActionResult ContactList()
        {
            var values = db.TblContact.ToList();
            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var values = db.TblContact.Find(id);
            db.TblContact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}