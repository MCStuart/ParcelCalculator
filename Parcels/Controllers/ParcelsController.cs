using Microsoft.AspNetCore.Mvc;
using ParcelShop;
using System.Collections.Generic;

namespace ParcelShop.Controllers
{
  public class ParcelsController : Controller
  {

    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      List<Parcel> newList = Parcel.GetAll();
      return View(newList);
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int length, int depth, int height, int weight)
    {
      Parcel myParcel = new Parcel(length, depth, height, weight);
      return RedirectToAction("Index");
    }

  }
}
