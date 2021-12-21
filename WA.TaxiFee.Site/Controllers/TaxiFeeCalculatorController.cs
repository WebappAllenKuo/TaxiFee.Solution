using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WA.TaxiFee.Site.Models.DTOs;
using WA.TaxiFee.Site.Models.Services;
using WA.TaxiFee.Site.Models.ViewModels;

namespace WA.TaxiFee.Site.Controllers
{
    public class TaxiFeeCalculatorController : Controller
    {
        // GET: TaxiFeeCalculator
        public ActionResult Ride()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ride(RideVM model)
        {
            var service = new TaxiFeeService();

            // RideDTO dto = model.ToDTO(); //  new RideDTO { Hour = model.Hour, Distance =model.Distance};

            var response = service.Calculate(model.ToDTO());

            ViewBag.Fee = response.Fee;

            return View(model);
        }
    }
}