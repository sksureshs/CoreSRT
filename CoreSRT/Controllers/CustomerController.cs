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
    public class CustomerController : Controller
    {
        // GET: /<controller>/
        private BillingContext _billingContext;

        public CustomerController(BillingContext billingRepository)
        {
            _billingContext = billingRepository;
        }

        [HttpPost]
        public IActionResult Create(CustomerViewModel customerViewModel)
        {
            var customer = Map(customerViewModel);
            _billingContext.CreateCustomer(customer);
            return Redirect("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id.HasValue)
            {
                _billingContext.DeleteItem(id.Value);
            }

            return Index();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var items = _billingContext.GetAllCustomer().Select(Map).ToList();

            return View("Index", items);
        }

        public IActionResult Edit(int? id)
        {
            if (id.HasValue)
            {
                var item = Map(_billingContext.GetCustomer(id.Value));

                return View(item);
            }
            return Index();
        }

        [HttpPost]
        public IActionResult Edit(int id, CustomerViewModel customerViewModel)
        {

            var customer = Map(customerViewModel);
            customer.CustomerId = id;
            _billingContext.UpdateCustomer(id, customer);
            return Redirect("Index");
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
                Type = customer.Type.ToString()
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
    }
}
