
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Educal_PB101.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}