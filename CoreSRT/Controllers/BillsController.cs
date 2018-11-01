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
            model.BillingItems[0].Items = _billingContext.GetActiveItems().Select(Map).ToList();
            return View(model);
        }

        [HttpPost]
        public JsonResult Create([FromBody]BillCreateJsonModel modelJson)
        {

            var url = "";
            try
            {
                var model = modelJson;
                if (ModelState.IsValid && model != null && model.CustomerId >= 0)
                {
                    var billItems = model.Items.Select(b => GetBillingItem(b)).ToList();
                    var billno = _billingContext.CreateBill(GetBill(model), billItems);

                    url = Url.Action("Print?billNo=" + billno);
                    return new JsonResult(new Dictionary<string, string>() { { "RedirectURL", url } });
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            throw new Exception(" Model state is invlaid or invalid inputs!");
        }

        public ActionResult Print(int billNo)
        {
            var bill = _billingContext.GetBill(billNo);
            var billingItems = _billingContext.GetBillingItems(billNo).ToList();
            var model = GetPrintViewModel(bill, billingItems.ToList());
            return View(model);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var model = new List<BillIndexViewModel>();
            model.AddRange(_billingContext.GetBills().Select(Map).ToList());
            return View("Index",model);
        }



        public ActionResult Edit(int billNo)
        {
            var model = new BillViewModel();
            model.BillingItems = new List<BillingItemViewModel>{
                new BillingItemViewModel()
            };
            var bill = _billingContext.GetBill(billNo);
            if(bill != null){
                model.Customers = _billingContext.GetAllCustomer().Select(Map).ToList();
                model.BillingItems[0].Items = _billingContext.GetActiveItems().Select(Map).ToList();
                model.BillNo = bill.BillId;
                model.BillingItems = _billingContext.GetBillingItems(billNo).Select((x,i) => MapToBillingItemView(x, i)).ToList();
                model.CustomerId = bill.ShopCustomerId;
                model.BillDate = bill.Date;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(int billNo, [FromBody]BillCreateJsonModel modelJson)
        {
            var url = "";
            try
            {
                var model = modelJson;
                if (billNo > 0 && ModelState.IsValid && model != null && model.CustomerId >= 0)
                {
                    var billItems = model.Items.Select(b => GetBillingItem(b)).ToList();
                    var bill = GetBill(model);
                    bill.BillId = billNo;
                    var billno = _billingContext.UpdateBill(bill, billItems);

                    url = Url.Action("Print?billNo=" + billno);
                    return new JsonResult(new Dictionary<string, string>() { { "RedirectURL", url } });
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            throw new Exception(" Model state is invlaid or invalid inputs!");
        }

        private BillingItemViewModel MapToBillingItemView(BillingItem billingItem, int index)
        {
            var gstAmt = billingItem.SellingPrice * (billingItem.CGST / 100);
            return new BillingItemViewModel{
                BillingItemId = billingItem.BillingItemId,
                CGST = billingItem.CGST,
                SGST = billingItem.SGST,
                CGSTAmount = gstAmt,
                SGSTAmount = gstAmt,
                Description = _billingContext.GetItem(billingItem.ItemId).Description,
                ItemId = billingItem.ItemId,
                OriginalPrice = billingItem.OriginalPrice,
                SellingPrice = billingItem.SellingPrice,
                PerItemPrice = billingItem.SellingPrice + (gstAmt * 2),
                Items = _billingContext.GetAllItems().Select(Map).ToList(),
                TotalPrice = (billingItem.SellingPrice + (gstAmt * 2)) * billingItem.Quantity,
                Quantity = billingItem.Quantity,
                Index = index,
            };
        }

        private BillIndexViewModel Map(Bill bill)
        {
            return new BillIndexViewModel
            {
                BillId = bill.BillId,
                TotalAmount = bill.TotalPrice,
                Customer = bill.Shop.Name,
                TotalQuantity = bill.TotalQuantity
            };
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

            model.Items = _billingContext.GetActiveItems().Select(Map).ToList();

            return PartialView("BillingItemViewModel", model);
        }

        public IActionResult Delete(int id)
        {
            if (ModelState.IsValid)
            {
                _billingContext.DeleteBill(id);
            }

            return Index();
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
                BillingItemId = billingItem.BillingItemId,
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
                Date = billViewModel.BillDate,
                OutStandingAmount = billViewModel.Items.Sum(t=>t.TotalPrice),
                Shop = _billingContext.GetCustomer(billViewModel.CustomerId),
                TotalQuantity = billViewModel.Items.Sum(i=>i.Quantity),
                TotalPrice = billViewModel.Items.Sum(t => t.TotalPrice),
                ShopCustomerId = billViewModel.CustomerId,
            };
        }

        private BillingItem GetBillingItem(BillingItemCreateJsonModel viewModel)
        {
            var item = new BillingItem
            {
                CGST = viewModel.CGST,
                ItemId = viewModel.ItemId,
                OriginalPrice = viewModel.OriginalPrice,
                Quantity = viewModel.Quantity,
                SellingPrice = viewModel.SellingPrice,
                SGST = viewModel.SGST,
                TotalPrice = viewModel.TotalPrice,
                BillingItemId = viewModel.BillingItemId
            };

            item.Item = _billingContext.GetItem(viewModel.ItemId);
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
