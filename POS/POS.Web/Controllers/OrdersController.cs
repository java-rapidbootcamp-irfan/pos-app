using Microsoft.AspNetCore.Mvc;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrdersService _service;
        public OrdersController(AppDbContext context)
        {
            _service = new OrdersService(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var orders = _service.Get();
            return View(orders);
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
            [Bind("CustomersId, EmployeId, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry")] OrdersModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new OrdersEntity(request));
                return Redirect("Index");
            }
            return View("Add", request);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            var orders = _service.View(id);
            return View(orders);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var orders = _service.View(id);
            return View(orders);
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, CustomersId, EmployeId, OrderDate, RequiredDate, ShippedDate, ShipVia, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry")] OrdersModel orders)
        {
            if (ModelState.IsValid)
            {
                _service.Update(orders);
                return Redirect("Index");
            }
            return View("Edit", orders);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _service.Delete(id);
            return Redirect("/Orders");
        }
    }
}