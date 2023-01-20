using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrdersService _orderService;
        private readonly CustomerService _customerService;
        private readonly EmployeService _employeService;
        private readonly ProductService _productService;

        public OrdersController(AppDbContext context)
        {
            _orderService = new OrdersService(context);
            _customerService = new CustomerService(context);
            _employeService = new EmployeService(context);
            _productService = new ProductService(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var orders = _orderService.GetOrders();
            return View(orders);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Customer = new SelectList(_customerService.Get(), "Id", "Name");
            ViewBag.Employee = new SelectList(_employeService.Get(), "Id", "LastName");
            ViewBag.Product = new SelectList(_productService.Get(), "Id", "ProductName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(
            [Bind("CustomerId, EmployeId, OrderDate, RequiredDate, ShippedDate, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, OrderDetails")] OrdersModel request)
        {
            if (ModelState.IsValid)
            {
                _orderService.CreateOrder(request);
                return Redirect("Index");
            }
            return View("Add", request);
        }

        /*[HttpGet]
        public IActionResult Details(int? id)
        {
            var order = _orderService.ReadOrder(id);
            return View(order);
        }*/
        [HttpGet]
        public IActionResult Detail(int? id)
        {
            var order = _orderService.ReadOrderInvoice(id);
            return View(order);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ViewBag.Customer = new SelectList(_customerService.Get(), "Id", "Name");
            ViewBag.Employee = new SelectList(_employeService.Get(), "Id", "LastName");
            ViewBag.Product = new SelectList(_productService.Get(), "Id", "ProductName");
            var order = _orderService.ReadOrder(id);

            return View(order);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update([Bind("Id, CustomerId, EmployeId, OrderDate, RequiredDate, ShippedDate, Freight, ShipName, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, OrderDetails")] OrdersModel request)
        {
            if (ModelState.IsValid)
            {
                _orderService.UpdateOrder(request);
                return Redirect("Index");
            }
            return View("Edit", request);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            _orderService.DeleteCategory(id);
            return Redirect("/Order");
        }
    }
}
