using DataLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFBUMVC.Controllers
{
    public class LectureController : Controller
    {
        LectureRepository _repository;
        public LectureController()
        {
            _repository = new LectureRepository();
        }
        public IActionResult Index()
        {
            return View(_repository.GetLectures());
        }

        public IActionResult AddLecture()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLecture(Lecture lecture)
        {
            if (lecture.Credit <= 0 || String.IsNullOrEmpty(lecture.Name))
            {
                string valMessage = "DAta formatları hatalı";

                
                ViewData["hata"] = valMessage;
                ViewBag.hatalar = $"Viewbag:{valMessage}";
                return View();
            }

            _repository.AddLecture(lecture);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _repository.DeleteLecture(id);
            return RedirectToAction("Index");
        }


    }
}
