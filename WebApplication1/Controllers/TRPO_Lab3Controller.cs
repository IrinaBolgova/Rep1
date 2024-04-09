using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApplication1.Models;
using TRPO_Lab3.Library;

namespace TRPO_Lab3.WebApplication.Controllers
{
    public class TRPO_Lab3Controller : Controller
    {
        public IActionResult Index()
        {
        return View();
        }
        [HttpPost]
        public IActionResult Check(ModelViews model)
        {
            if (ModelState.IsValid)
            {
                double area = MathLib.CalculateSphereSectorSurfaceArea(model.radius_shara, model.radius_okrujnosti, model.height);
                ViewBag.area = area;
                return View();
            }
            return View("Index");
        }
    }
}
