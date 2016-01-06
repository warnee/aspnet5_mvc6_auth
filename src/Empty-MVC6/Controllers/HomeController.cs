using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Empty_MVC6.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/Menu
        public IActionResult Menu()
        {
            return View();
        }

        // GET: /Home/Item
        public IActionResult Item()
        {
            return View();
        }
    }
}
