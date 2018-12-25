using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ETP.Models;
using System.Net.Http;
using System.Text;

namespace ETP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /*ff*/
        private async Task<string> ValidateEmail(string emailToValidate)
        {
            string azureBaseUrl = "https://fa01-etp-test.azurewebsites.net/api/FunctionApp";
            string urlQueryStringParams = "?code=IuvfwR1NJ1gQHTJbJsDn1xmGS3BMg99DIcrX9crVl0WGBjurKwtoYg==&name=" + emailToValidate;

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(
                 $"{azureBaseUrl}{urlQueryStringParams}"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data; 
                        }
                        else
                            return null;
                    }
                }
            }
        }

        /*  Travel pages  */

        public IActionResult TravelCategory()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Travel()
        {
            Task<String> ar =  ValidateEmail("Hans IB");
            ViewData["Message"] = "Your contact page." + ar.Result;
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
