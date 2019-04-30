using FDMC.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FDMC.App.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(CatsContext context)

        {
            this.Context = context;
        }

        public CatsContext Context { get; set; }

        public IActionResult Index()
        {

            var cats = this.Context.Cats.ToList();
            return View(model: cats);
        }
       
    }
}
