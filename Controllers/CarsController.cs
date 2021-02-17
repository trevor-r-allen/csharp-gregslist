using System;
using System.Collections.Generic;
using csharp_gregslist.DB;
using csharp_gregslist.Models;
using csharp_gregslist.Services;
using Microsoft.AspNetCore.Mvc;

namespace csharp_gregslist.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CarsController : ControllerBase
  {

    private readonly CarsService _ds;
    public CarsController(CarsService ds)
    {
      _ds = ds;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
        return Ok(_ds.Get());
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
        Car car = _ds.Get(carId);
        return Ok(car);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car newCar)
    {
      try
      {
        Car car = _ds.Create(newCar);
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
        editedCar.Id = carId;
        Car car = _ds.Edit(editedCar);
        return Ok(car);
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
        _ds.Delete(carId);
        return Ok("Successfully Deleted");
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

  }
}