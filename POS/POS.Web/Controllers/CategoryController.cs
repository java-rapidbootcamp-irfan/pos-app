using Microsoft.AspNetCore.Mvc;
using POS.DataContext;
using POS.Repository;
using POS.Service;
using POS.ViewModel;

namespace POS.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryService _service;
        public CategoryController(AppDbContext context)
        {
            _service = new CategoryService(context);
        }

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
        [HttpPost]
        public IActionResult Save([Bind("CategoryName, Description")] CategoryModel request)
        {
            if (ModelState.IsValid)
            {
                _service.Add(new CategoryEntity(request));
                return Redirect("Index");
            }
            return View("Add", request);

        }
    }
}
        
           