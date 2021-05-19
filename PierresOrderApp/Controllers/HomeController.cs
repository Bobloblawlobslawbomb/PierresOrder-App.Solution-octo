using Microsoft.AspNetCore.Mvc;
using PierresOrderApp.Models;

namespace PierresOrderApp.Controllers
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