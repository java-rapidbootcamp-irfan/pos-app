using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class EmployeController : Controller
    {
        private readonly EmployeService _service;
        public EmployeController (AppDbContext context) 
        {
            _service = new EmployeService(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var Data = _service.Get();
            return View(Data);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddModal()
        {
            return PartialView("_Add");
        }

        [HttpPost]
        public IActionResult Save(
            [Bind("LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo, PhotoPath")] EmployeModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new EmployeEntity(request));
                return Redirect("Index");
            }
            return View("Add", request);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var employe = _service.View(id);
            return View(employe);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var employe = _service.View(id);
            return View(employe);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, Address, City, Region, PostalCode, Country, HomePhone, Extension, Notes, ReportsTo, PhotoPath")] EmployeModel employe)
        {
            if (ModelState.IsValid)
            {
                _service.Update(employe);
                return Redirect("Index");
            }
            return View("Edit", employe);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Employe");
        }
    }
}