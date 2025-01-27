﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbDominicPortfolioEntities2 db = new DbDominicPortfolioEntities2();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }
        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }
        public PartialViewResult FeaturePartial()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }
        public PartialViewResult AboutPartial()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }
        public PartialViewResult ServicePartial()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }
        public PartialViewResult TestimonialPartial()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
        public PartialViewResult ProjectPartial()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }
        public PartialViewResult ContactPartial()
        {
            var values = db.TblContact.ToList();
            return PartialView(values);
        }
        public PartialViewResult SidebarPartial()
        {
            return PartialView();
        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();
        }

    }
}