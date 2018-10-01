using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreSRT.Models.ViewModels;
using CoreSRTModels;
using CoreSRTRepository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CoreSRT.Controllers
{
    public class ItemsController : Controller
    {
        // GET: /<controller>/
        private BillingContext _billingContext;

        public ItemsController(BillingContext billingRepository)
        {
            _billingContext = billingRepository;
        }

        [HttpPost]
        public IActionResult Create(ItemViewModel itemViewModel)
        {
            var item = Map(itemViewModel);
            item.DateFrom = DateTime.Now;
            item.DateTo = DateTime.MaxValue;
            _billingContext.CreateItem(item);
            return Index();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Bills()
        {
            var bills = new List<BillViewModel>
            {
                new BillViewModel
                {
                    CustomerName = "cus1",
                    Total = 34.3m
                },
                new BillViewModel
                {
                    CustomerName = "cus2",
                    Total=50m
                }
            };

            return View(bills);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var temp = _billingContext.GetAllItems().ToList();

            temp[0].ItemId = 10;

            var items = new List<ItemViewModel>
            {
                new  ItemViewModel
                {
                    Description = "Dump Item1"
                }
            };
            items.AddRange(temp.Select(Map).ToList());

            return View("Index", items);
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

        private Item Map(ItemViewModel model)
        {
            return new Item
            {
                CGST = model.CGST,
                DateFrom=model.DateFrom,
                DateTo = model.DateTo,
                Description = model.Description,
                Rate = model.Rate,
                SGST = model.SGST,
            };
        }
    }
}
