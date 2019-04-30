using Microsoft.AspNetCore.Mvc;

namespace ParcelShop.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      //
      // public ActionResult Index()
      // {
      //   return new EmptyResult();
      // }

    }
}
