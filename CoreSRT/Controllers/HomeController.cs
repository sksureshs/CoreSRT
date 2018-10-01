using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreSRT.Models;
using CoreSRTRepository;
using CoreSRT.Models.ViewModels;
using CoreSRTModels;

namespace CoreSRT.Controllers
{
    public class HomeController : Controller
    {
        private BillingContext _billingRepository;

        public HomeController(BillingContext billingRepository)
        {
            _billingRepository = billingRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Items()
        {
           
            return View(_billingRepository.GetAllItems().Select(Map).ToList());
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private ItemViewModel Map(Item item)
        {
            return new ItemViewModel
            {
                CGST = item.CGST,
                DateFrom = item.DateFrom,
                DateTo = item.DateTo,
                Description = item.Description,
                Rate = item.Rate,
                SGST = item.SGST
            };
        }
    }
}
