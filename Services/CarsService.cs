using System;
using System.Collections.Generic;
using csharp_gregslist.DB;
using csharp_gregslist.Models;

namespace csharp_gregslist.Services
{
  public class CarsService
  {
    public IEnumerable<Car> Get()
    {
      return FAKEDB.Cars;
    }

    public Car Get(string carId)
    {
      Car car = FAKEDB.Cars.Find(c => c.Id == carId);
      if (car == null)
      {
        throw new Exception("Invalid Id");
      }
      return car;
    }

    public Car Create(Car newCar)
    {
      FAKEDB.Cars.Add(newCar);
      return newCar;
    }

    public Car Edit(Car editedCar)
    {
      Car car = FAKEDB.Cars.Find(c => c.Id == editedCar.Id);
      if (car == null)
      {
        throw new Exception("Invalid Id");
      }
      FAKEDB.Cars.Remove(car);
      FAKEDB.Cars.Add(editedCar);
      return editedCar;
    }

    public string Delete(string carId)
    {
      Car car = FAKEDB.Cars.Find(c => c.Id == carId);
      if (car == null)
      {
        throw new Exception("Invalid Id");
      }
      FAKEDB.Cars.Remove(car);
      return "Successfully Deleted";
    }


  }
}