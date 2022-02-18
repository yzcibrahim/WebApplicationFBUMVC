using DataLayer;
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
            PersonRepository repository = new PersonRepository();
            people = repository.GetPeople();
            return View(people);
        }


        [HttpPost]
        public IActionResult CreatePerson(string name, string surname)
        {

            PersonRepository repository = new PersonRepository();

            // Person p = new Person(Request.Query["name"], Request.Query["surname"]);
            Person p = new Person(name, surname);

            repository.AddPerson(p);
            // return View();
            return RedirectToAction("YeniSayfa");
        }

        public IActionResult CreatePerson()
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
