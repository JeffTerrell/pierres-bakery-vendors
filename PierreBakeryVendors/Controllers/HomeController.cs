using Microsoft.AspNetCore.Mvc;

namespace PierreBakeryVendors.Controllers
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