using Microsoft.AspNetCore.Mvc;

namespace crudapiwithjquery.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }

        public IActionResult Delete(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.ProductId = id;
            return View();
        }
    }
}
