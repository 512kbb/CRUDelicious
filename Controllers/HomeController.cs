using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private CRUDeliciousDbContext _context;

    public HomeController(ILogger<HomeController> logger, CRUDeliciousDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        List<Dish> AllDishes = _context.Dishes.ToList();
        ViewBag.Dishes = AllDishes;
        return View();
    }

    [HttpGet("dishes/new")]
    public IActionResult AddADish()
    {
        return View();
    }

    [HttpPost("dishes/new")]
    public IActionResult AddDish(Dish newDish)
    {
        if (ModelState.IsValid)
        {
            _context.Add(newDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        else
        {
            return View("AddADish");
        }
    }

    [HttpGet("dishes/{dishId}")]
    public IActionResult DishDetails(int dishId)
    {
        Dish dish = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
        return View(dish);
    }

    [HttpGet("dishes/{dishId}/edit")]
    public IActionResult EditDish(int dishId)
    {
        Dish dish = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
        return View(dish);
    }

    [HttpPost("dishes/{dishId}/edit")]
    public IActionResult UpdateDish(int dishId, Dish updatedDish)
    {
        Dish? dish = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if (ModelState.IsValid)
        {
            dish.Name = updatedDish.Name;
            dish.Chef = updatedDish.Chef;
            dish.Calories = updatedDish.Calories;
            dish.Tastiness = updatedDish.Tastiness;
            dish.Description = updatedDish.Description;
            _context.SaveChanges();
            return RedirectToAction("DishDetails", new { dishId = dish.DishId });
        }
        else
        {
            return View("EditDish", dish);
        }
    }

    [HttpGet("dishes/{dishId}/delete")]
    public IActionResult DeleteDish(int dishId)
    {
        Dish? dish = _context.Dishes.FirstOrDefault(d => d.DishId == dishId);
        _context.Dishes.Remove(dish);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
