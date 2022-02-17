using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFBUMVC.Models;

namespace WebApplicationFBUMVC.Controllers
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
            return View();
        }

        public IActionResult PureHtml()
        {
            return View();
        }
        public IActionResult YeniSayfa()
        {
            List<Person> people = new List<Person>();
            
            Person p = new Person("ibrahim","yazıcı");

            people.Add(p);
            people.Add(new Person("Göktuğ", "Kozkaya"));
            people.Add(new Person("Kaan", "Karalı"));
            people.Add(new Person("Alper", "Ayık"));
            people.Add(new Person("Çağatay", "Kamit"));
            return View(people);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
