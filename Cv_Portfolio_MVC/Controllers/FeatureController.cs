﻿using Business.Concrete;
using DataAccess.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Cv_Portfolio_MVC.Controllers
{
    public class FeatureController : Controller
        
    {
        FeatureManager featureManager = new FeatureManager(new EfFeature());
        public IActionResult Index()
        {
            var values = featureManager.GetByIDT(1);
            return View(values);
        }
        [HttpPost]
        public IActionResult Index(Feature feature)
        {
            featureManager.UpdateT(feature);
            return RedirectToAction("Index","Default");
        }
    }
}
