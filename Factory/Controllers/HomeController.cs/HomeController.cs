using Factory.Models;
using Microsoft.AspNetCore.Mvc;

namespace Factory.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}