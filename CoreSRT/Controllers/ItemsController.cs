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
            return Redirect("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (ModelState.IsValid && id!= null)
            {
                if (id.HasValue)
                {
                    _billingContext.DeleteItem(id.Value);
                }
            }
            else
            {
                ViewData["Error"] = "Invalid Model State";
            }
            return Index();


        }

        [HttpGet]
        public IActionResult Index()
        {
            var items = _billingContext.GetActiveItems().Select(Map).ToList();

            return View("Index", items);
        }

        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var item = Map(_billingContext.GetItem(id.Value));

                return View(item);
            }
            return Index();
        }

        [HttpPost]
        public IActionResult Edit(int id, ItemViewModel itemViewModel)
        {

            var item = Map(itemViewModel);
            item.ItemId = id;
            item.DateFrom = DateTime.Now;
            item.DateTo = DateTime.MaxValue;
            _billingContext.UpdateItem(item);
            return Redirect("Index");
        }

        private ItemViewModel Map(Item item)
        {
            return new ItemViewModel
            {
                Id = item.ItemId,
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
                ItemId = model.Id,
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
