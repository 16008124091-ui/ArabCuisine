using Microsoft.AspNetCore.Mvc;

namespace ArabCuisine.Controllers
{
    public class CountryController : Controller
    {
        ///categories sayfasi
        public IActionResult Categories(string name)
        {
            ViewBag.CountryName = name;
            return View();
        }
        //recipes sayfasi 
        public IActionResult Recipes(string country, string category)
        {
            ViewBag.Country = country;
            ViewBag.Category = category;
            return View();
        }
        ///recipe detail sayfasi
        public IActionResult RecipeDetails(string name)
        { ViewBag.RecipeName = name;
        return View();
        }
    }
}

