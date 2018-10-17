using System;
using System.Collections.Generic;
using System.Linq;
using CoreSRT.Models.ViewModels;
using CoreSRTModels;
using CoreSRTRepository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CoreSRT.Controllers
{
    public class BillsController : Controller
    {
        private readonly BillingContext _billingContext;

        public BillsController(BillingContext billingRepository)
        {
            _billingContext = billingRepository;
        }

        public ActionResult Create()
        {
            var model = new BillViewModel();
            model.BillingItems = new List<BillingItemViewModel>{
                new BillingItemViewModel()
            };
            model.Customers = _billingContext.GetAllCustomer().Select(Map).ToList();
            model.BillingItems[0].Items = _billingContext.GetAllItems().Select(Map).ToList();
            return View(model);
        }

        [HttpPost]
        public int Create([FromBody]BillCreateJsonModel modelJson)
        {
            var model = modelJson;
            if (ModelState.IsValid)
            {
                var billItems = model.Items.Select(b => GetBillingItem(b)).ToList();
                var billno = _billingContext.CreateBill(GetBill(model), billItems);
                return billno;
            }
            return 0;
        }

        public ActionResult Print(int billNo)
        {
            var bill = _billingContext.GetBill(billNo);
            var billingItems = _billingContext.GetBillingItems(billNo).ToList();
            var model = GetPrintViewModel(bill, billingItems.ToList());
            return View(model);
        }

        public ActionResult Index()
        {
            return null;
        }

        public ActionResult AddItemNew(BillViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.BillingItems == null) model.BillingItems = new List<BillingItemViewModel>();
                model.BillingItems.Add(new BillingItemViewModel());
                model.BillingItems.Last().Items = _billingContext.GetAllItems().Select(Map).ToList();
            }

            return View("Create",model);
        }

        public PartialViewResult AddItem(int index)
        {
            var model = new BillingItemViewModel{
                Index = index
            };

            ViewData.TemplateInfo.HtmlFieldPrefix = string.Format("BillingItems[{0}]", index);

            model.Items = _billingContext.GetAllItems().Select(Map).ToList();

            return PartialView("BillingItemViewModel", model);
        }

        private BillPrintViewModel GetPrintViewModel(Bill bill, IList<BillingItem>billingItems)
        {
            var billViewModel = new BillPrintViewModel
            {
                BillDate = bill.Date,
                BillNo = bill.BillId,
                Buyer  = Map(bill.Shop),
                Seller = new CustomerViewModel
                {
                    Address = "5, Sri Amman Nagar, Vilankurichi, Coimbatore-35",
                    ContactNumber = "9629624444",
                    EmailId = "sreerangatraderscbe@gmail.com",
                    Name = "Sree Ranga Traders",
                    GSTNo = "33BJJPS5029L1ZT",

                },
                Items = billingItems.Select(Map).ToList(),
            };

            return billViewModel;
        }

        private BillPrintItemViewModel Map(BillingItem billingItem)
        {
            var model =  new BillPrintItemViewModel
            {
                BillingItemId = billingItem.BillingItmeId,
                Price = billingItem.SellingPrice,
                CGST = billingItem.CGST,
                SGST = billingItem.SGST,
                Description = billingItem.Item.Description,
                Quantity = billingItem.Quantity,
            };

            return model;
        }

        private Bill GetBill(BillCreateJsonModel billViewModel)
        {
            return new Bill
            {
                Date = DateTime.Now,
                OutStandingAmount = billViewModel.Items.Sum(t=>t.TotalPrice),
                Shop = _billingContext.GetCustomer(billViewModel.CustomerId),
                TotalQuantity = billViewModel.Items.Count(),
                TotalPrice = billViewModel.Items.Sum(t => t.TotalPrice)
            };
        }

        private BillingItem GetBillingItem(BillingItemCreateJsonModel viewModel)
        {
            var item = new BillingItem
            {
                CGST = viewModel.CGST,

                OriginalPrice = viewModel.OriginalPrice,
                Quantity = viewModel.Quantity,
                SellingPrice = viewModel.SellingPrice,
                SGST = viewModel.SGST,
                TotalPrice = viewModel.TotalPrice
            };

            item.Item = _billingContext.GetItem(viewModel.BillingItemId);
            return item;
        }



        private CustomerViewModel Map(Customer customer)
        {
            return new CustomerViewModel
            {
                Address = customer.Address,
                ContactNumber = customer.ContactNumber,
                CustomerId = customer.CustomerId,
                EmailId = customer.EmailId,
                GSTNo = customer.GSTNo,
                Name = customer.Name,
                TypeId = (int)customer.Type,

            };
        }


        private Customer Map(CustomerViewModel customerViewModel)
        {
            return new Customer
            {
                Address = customerViewModel.Address,
                ContactNumber = customerViewModel.ContactNumber,
                CustomerId = customerViewModel.CustomerId,
                EmailId = customerViewModel.EmailId,
                GSTNo = customerViewModel.GSTNo,
                Name = customerViewModel.Name,
                Type = (CustomerType)customerViewModel.TypeId
            };
        }

        private Item Map(ItemViewModel model)
        {
            return new Item
            {
                ItemId = model.Id,
                CGST = model.CGST,
                DateFrom = model.DateFrom,
                DateTo = model.DateTo,
                Description = model.Description,
                Rate = model.Rate,
                SGST = model.SGST,
            };
        }

        private ItemViewModel Map(Item item)
        {
            return new ItemViewModel
            {
                Id = item.ItemId,
                CGST = item.CGST,
               
                //DateTo = item.DateTo,
                Description = item.Description,
                Rate = item.Rate,
                SGST = item.SGST
            };
        }

    }
}
