using System.Collections.Generic;

namespace Dealership.Models
{
  public class Car
  {
    public string MakeModel { get; }
    public string Price { get; }
    public string Mileage { get; }
    public static List<Car> Lot { get; } = new List<Car> {};
    public Car(string makeModel, string price, string mileage)
    {
      MakeModel = makeModel;
      Price = price;
      Mileage = mileage;
      Lot.Add(this);
    }
  }
}