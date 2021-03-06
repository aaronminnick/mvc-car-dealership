using Dealership.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/car")]
    public ActionResult Index()
    {
      return View(Car.Lot);
    }

    [HttpPost("/car")]
    public ActionResult AddingCar(IFormCollection input)
    {
      string yearMakeModel = input["year"] + " " + input["makeModel"];
      Car addedCar = new Car(yearMakeModel, input["price"], input["mileage"]);
      return RedirectToAction("Index");
    }

    [HttpGet("/addcar")]
    public ActionResult AddCarForm()
    {
      return View();
    }
  }
}