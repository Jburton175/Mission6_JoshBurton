using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission6.Models;

public class HomeController : Controller
{
    private readonly Mission6DB _context;
    private readonly ILogger<HomeController> _logger;

    public HomeController(Mission6DB temp, ILogger<HomeController> logger)
    {
        _context = temp;
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult About()
    {
        return View();
    }

    [HttpGet]
    public IActionResult NewMovie()
    {
        return View("NewMovie");
    }

    [HttpPost]
    public IActionResult NewMovie(Application response)
    {
        _context.Movies.Add(response);
        _context.SaveChanges();

        return View("Complete", response);

    }


    public IActionResult MovieList()
    {
        var response = _context.Movies
            .OrderBy(x => x.Year).ToList();

        return View(response);
    }

    [HttpGet]

    public IActionResult Edit(int id)
    {
        var response = _context.Movies
            .Single(x => x.MovieID.Equals(id));

        return View("EditMovie", response);
    }

    [HttpPost]
    public IActionResult Edit(Application info)
    {
        _context.Update(info);
        _context.SaveChanges();


        return RedirectToAction("MovieList");

    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var del_record = _context.Movies
            .Single(x => x.MovieID.Equals(id));

        return View(del_record);

    }

    [HttpPost]
    public IActionResult Delete(Application info)
    {
        _context.Movies.Remove(info);
        _context.SaveChanges();

        return RedirectToAction("MovieList");
    }


}
