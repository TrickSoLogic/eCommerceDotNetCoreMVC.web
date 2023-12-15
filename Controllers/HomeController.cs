﻿using eCommerceDotNetCoreMVC.web.Models;
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
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}