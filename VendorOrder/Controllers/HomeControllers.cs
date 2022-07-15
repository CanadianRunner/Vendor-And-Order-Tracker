using Microsoft.AspNetCore.Mvc;

namespace BakeryStore.Controllers
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