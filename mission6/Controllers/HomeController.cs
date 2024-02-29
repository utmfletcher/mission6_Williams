using Microsoft.AspNetCore.Mvc;
using mission6.Models;
using SQLitePCL;
using System.Diagnostics;

namespace mission6.Controllers
{
    public class HomeController : Controller
    {
        private MovieApplicationContext _context;
        public HomeController(MovieApplicationContext temp) 
        {
            _context = temp;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovie() 
        {
            return View();  
        }

        [HttpPost]
        public IActionResult AddMovie(Application response)
        {
            _context.Applications.Add(response);   
            _context.SaveChanges();

            return View("Confirmation", response);
        }



    }
}
