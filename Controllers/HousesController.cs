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
  public class HousesController : ControllerBase
  {

    private readonly HousesService _ds;
    public HousesController(HousesService ds)
    {
      _ds = ds;
    }

    [HttpGet]
    public ActionResult<IEnumerable<House>> Get()
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

    [HttpGet("{houseId}")]
    public ActionResult<House> Get(string houseId)
    {
      try
      {
        House house = _ds.Get(houseId);
        return Ok(house);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<House> Create([FromBody] House newhouse)
    {
      try
      {
        House house = _ds.Create(newhouse);
        return Ok(newhouse);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPut("{houseId}")]
    public ActionResult<House> Edit([FromBody] House editedhouse, string houseId)
    {
      try
      {
        editedhouse.Id = houseId;
        House house = _ds.Edit(editedhouse);
        return Ok(house);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{houseId}")]
    public ActionResult<String> Delete(string houseId)
    {
      try
      {
        _ds.Delete(houseId);
        return Ok("Successfully Deleted");
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

  }
}