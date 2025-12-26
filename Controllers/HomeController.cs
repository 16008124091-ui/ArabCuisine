using ArabCuisine.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ArabCuisine.Controllers
{
    public class  HomeController : Controller
    {
        public IActionResult Index ()
        {
            var countries = new
            List<Country>();
            {
                new Country
                {
                    Id = 1,
                    Name = "Iraq",
                    ImageUrl = "/images/iraq.png",
                };
                new Country
                {
                    Id = 2,
                    Name = "Jordan",
                    ImageUrl = "/images/jordan.png",
                };
                new Country
                {
                    Id = 3,
                    Name = "Syria",
                    ImageUrl = "/images/syria.png",
                };
                new Country
                {
                    Id = 4,
                    Name = "Morocco",
                    ImageUrl = "/images/morocco.png",
                };
                new Country
                {
                    Id = 5,
                    Name = "Palestine",
                    ImageUrl = "/images/palestine.png",
                };
            };

            return View(countries);
        }
        public IActionResult Test()
        {
            return Content("MVC OK");
        }
    }
}