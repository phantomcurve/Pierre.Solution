using Microsoft.AspNetCore.Mvc;
using PierreJustCannotHelpHimself.Models;
using System.Collections.Generic;
using System.Linq;

namespace PierreJustCannotHelpHimself.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierreJustCannotHelpHimselfContext _db;

    public HomeController(PierreJustCannotHelpHimselfContext db)
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