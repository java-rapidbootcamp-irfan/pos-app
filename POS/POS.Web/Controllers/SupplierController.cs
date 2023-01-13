using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class SupplierController : Controller
    {
        private readonly SupplierService _service;
        public SupplierController(AppDbContext context) 
        {
            _service = new SupplierService(context);
        }
        public ActionResult Index() 
        {
            var Data = _service.Get();
            return View(Data);
        }
        [HttpGet]
        public ActionResult Add() 
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddModal() 
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public ActionResult Save([Bind("CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage")]SupplierModel 
            request) 
        {
            if(ModelState.IsValid) 
            {
                _service.Add(new SupplierEntity(request));
                return Redirect("Index");
            }
            return View("Add" , request);  
        }
        [HttpGet]
        public ActionResult Details(int? id) 
        {
            var supplier = _service.View(id);  
            return View(supplier);  
        }
        [HttpGet]
        public ActionResult Edit(int? id) 
        {
            var supplier = _service.View(id);
            return View(supplier);  
        }
        [HttpPost]
        public ActionResult Update([Bind("Id, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax, HomePage")]
        SupplierModel supplier) 
        {
            if (ModelState.IsValid) 
            {
                _service.Update(supplier);
                return Redirect("Index");   
            }
            return View("Edit", supplier);
        }
        [HttpGet]   
        public ActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Supplier");   
        }
    }
}
