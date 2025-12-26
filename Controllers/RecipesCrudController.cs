using ArabCuisine.Data;
using ArabCuisine.Models;
using Microsoft.AspNetCore.Mvc;

public class RecipesCrudController : Controller
{
    private readonly AppDbContext _context;

    public RecipesCrudController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Recipe recipe)
    {
        _context.Recipes.Add(recipe);
        _context.SaveChanges();
        return RedirectToAction("Index", "Home");
    }
}
