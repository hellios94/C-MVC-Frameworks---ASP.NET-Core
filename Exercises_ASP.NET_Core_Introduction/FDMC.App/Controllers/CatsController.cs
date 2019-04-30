using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Data;
using FDMC.Model;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.App.Controllers
{
    public class CatsController : Controller
    {

        public CatsController(CatsContext context)
        {
            this.Context = context;
        }

        public CatsContext Context { get; set; }

        public IActionResult Details(int id)
        {
            var cats = this.Context.Cats.ToList();

            var cat = cats.Find(c => c.Id == id);

            return View(model: cat);
        }

        public IActionResult AddCat()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCat(string name, int age, string breed, string imageUrl)
        {

            var cat = new Cat()
            {
                Name = name,
                Age = age,
                Breed = breed,
                ImageUrl = imageUrl
            };

            this.Context.Add(cat);
            this.Context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}