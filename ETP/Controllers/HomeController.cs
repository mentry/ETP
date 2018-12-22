using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ETP.Models;

namespace ETP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*  Travel pages  */

        public IActionResult TravelCategory()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Travel()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult TravelPlan()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /*  Booking pages  */

        public IActionResult Booking()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        /* User pages*/

        public IActionResult MyTravels()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult MyInformation()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
