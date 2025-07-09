using BtkAkademi.Models;
using Microsoft.AspNetCore.Mvc;

namespace BtkAkademi.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Apply()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]//Güvenlik için kullanılır, CSRF saldırılarına karşı koruma sağlar.
        public IActionResult Apply([FromForm]Candidate model)
        {
            return View();
        }

    }
}