using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationFBUMVC.Models;

namespace WebApplicationFBUMVC.Controllers
{
    public class PersonController : Controller
    {
        PersonRepository _repository;
        public PersonController(PersonRepository repository)
        {
            _repository = repository;
        }
        public IActionResult List()
        {
            return RedirectToAction("Index", "Lecture");
            List<Person> people = _repository.GetPeople();

            List<PersonViewModel> model = new List<PersonViewModel>();

            foreach(var person in people)
            {

                PersonViewModel pw = new PersonViewModel();
                pw.Id = person.Id;
                pw.Name = person.Name;
                pw.Surname = person.Surname;
                model.Add(pw);
                //model.Add(new PersonViewModel() { Id = person.Id, Name = person.Name, Surname = person.Surname });
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(string Name, string Surname)
        //{
        //    Person p = new Person(Name, Surname);
        //    return RedirectToAction("List");
        //}

        [HttpPost]
        public IActionResult Create(Person p)
        {
            _repository.AddPerson(p);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var _people = _repository.GetPeople();
            var _person = _people.FirstOrDefault(c => c.Id == id);

            PersonViewModel model = new PersonViewModel()
            {
                Id = _person.Id,
                Name = _person.Name,
                Surname = _person.Surname
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(PersonViewModel p)
        {
            if(!ModelState.IsValid)
            {
                return View(p);
            }
           
            Person _person = new Person() { Id = p.Id, Name = p.Name, Surname = p.Surname };
            _repository.UpdatePerson(_person);
            return RedirectToAction("List");
        }

        public IActionResult Delete(int id,int asdasd)
        {
            _repository.DeletePerson(id);
            return RedirectToAction("List");
        }

       
    }
}
