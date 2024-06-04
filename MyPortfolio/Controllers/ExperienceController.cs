using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }
        [HttpGet]//Sayfa yüklenince çalışacak
        public IActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]//Sayfada bir butona tıklandığında çalışacak
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience); //ekleme işlemini yap
            context.SaveChanges(); //Gelen değeri değiştirip kaydet
            return RedirectToAction("ExperienceList"); //Tekrar Listeye yönlendir
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id); //id'ye göre bul
            context.Experiences.Remove(value); 
            context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
		}

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();
			return RedirectToAction("ExperienceList");
		}
	}
}
