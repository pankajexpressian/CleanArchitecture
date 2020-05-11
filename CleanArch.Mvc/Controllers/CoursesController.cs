using Microsoft.AspNetCore.Mvc;
using CleanArch.Application.Interfaces;

namespace CleanArch.Mvc.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {

            _courseService = courseService;
        }

        // GET: Courses
        public IActionResult Index()
        {

            return View(_courseService.GetCourses());
        }
    }
}
