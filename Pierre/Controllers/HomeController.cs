using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;
using System.Linq;

namespace Pierre.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreContext _db;

    public HomeController(PierreContext db)
    {
      _db = db;
    }

    [HttpGet("/")]

    public ActionResult Index()
    {
      ViewBag.DelectableDirectory = new List<Treat>(_db.Treats.OrderBy(treat => treat.Name));
      ViewBag.FlavorDirectory = new List<Flavor>(_db.Flavors.OrderBy(flavor => flavor.Name));
      return View();
    }


  }
}