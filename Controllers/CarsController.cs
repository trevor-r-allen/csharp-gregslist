using System;
using System.Collections.Generic;
using csharp_gregslist.DB;
using csharp_gregslist.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_gregslist.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
        return Ok(FAKEDB.Cars);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpGet("{carId}")]
    public ActionResult<Car> Get(string carId)
    {
      try
      {
        Car carToReturn = FAKEDB.Cars.Find(c => c.Id == carId);
        return Ok(carToReturn);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody], Car newCar)
    {
      try
      {
        FAKEDB.Cars.Add(newCar);
        return Ok(newCar);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPut("{carId}")]
    public ActionResult<Car> Edit([FromBody] Car editedCar, string carId)
    {
      try
      {
        Car carToEdit = FAKEDB.Cars.Find(c => c.Id == carId);
        FAKEDB.Cars.Remove(carToEdit);
        editedCar.Id = carId;
        FAKEDB.Cars.Add(editedCar);
        return Ok(editedCar);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{carId}")]
    public ActionResult<String> Delete(string carId)
    {
      try
      {
        Car carToRemove = FAKEDB.Cars.Find(c => c.Id == carId);
        FAKEDB.Cars.Remove(carToRemove);
        return Ok("Successfully Deleted");
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

  }
}