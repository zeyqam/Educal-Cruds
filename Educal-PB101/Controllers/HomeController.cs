
using Educal_PB101.Services.Interfaces;
using Educal_PB101.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Educal_PB101.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly ICourseService _courseService;
        public HomeController(ICategoryService categoryService, 
                              ICourseService courseService)
        {
            _categoryService = categoryService;
            _courseService = courseService;

        }


        public async Task<IActionResult> Index()
        {
            HomeVM model = new()
            {
                Categories=await _categoryService.GetAllAsync(),
                Courses=await _courseService.GetAllAsync()
            };
            return View(model);
        }
    }
}