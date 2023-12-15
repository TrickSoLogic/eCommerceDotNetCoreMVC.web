using eCommerceDotNetCoreMVC.web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eCommerceDotNetCoreMVC.web.Controllers
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
        public IActionResult Privacy()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }  public IActionResult Privacy1()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }  public IActionResult Privacy2()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }  public IActionResult Privacy3()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }  public IActionResult Privacy4()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }  public IActionResult Privacy5()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }  public IActionResult Privacy6()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
        public IActionResult Privacy7()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
        public IActionResult Privacy8()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
        public IActionResult Privacy9()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
        public IActionResult Privacy10()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy10232()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy10112()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy1022()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy101()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy102()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy1043()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy10435()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy10543()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy10324()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }
          public IActionResult Privacy10453()
        {
            // Set a welcome message for all users
            ViewData["WelcomeMessage"] = "Welcome to the eCommerce site made by Vishal Bhat.";

            // Return the view
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}