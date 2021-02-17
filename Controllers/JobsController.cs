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
  public class JobsController : ControllerBase
  {

    private readonly JobsService _ds;
    public JobsController(JobsService ds)
    {
      _ds = ds;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Job>> Get()
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

    [HttpGet("{jobId}")]
    public ActionResult<Job> Get(string jobId)
    {
      try
      {
        Job job = _ds.Get(jobId);
        return Ok(job);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPost]
    public ActionResult<Job> Create([FromBody] Job newjob)
    {
      try
      {
        Job job = _ds.Create(newjob);
        return Ok(newjob);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpPut("{jobId}")]
    public ActionResult<Job> Edit([FromBody] Job editedjob, string jobId)
    {
      try
      {
        editedjob.Id = jobId;
        Job job = _ds.Edit(editedjob);
        return Ok(job);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

    [HttpDelete("{jobId}")]
    public ActionResult<String> Delete(string jobId)
    {
      try
      {
        _ds.Delete(jobId);
        return Ok("Successfully Deleted");
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }

  }
}