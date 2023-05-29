using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserInterfaceApplication.Models;

namespace UserInterfaceApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Performance()
        {
            return View();
        }

        public IActionResult AddFolder()
        {
            return View();
        }

        public IActionResult FolderList()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult AddCustomer()
        {
            return View();
        }
		public IActionResult CustomerList()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}