using System;
using System.Collections.Generic;
using csharp_gregslist.DB;
using csharp_gregslist.Models;

namespace csharp_gregslist.Services
{
  public class JobsService
  {
    public IEnumerable<Job> Get()
    {
      return FAKEDB.Jobs;
    }

    public Job Get(string jobId)
    {
      Job job = FAKEDB.Jobs.Find(c => c.Id == jobId);
      if (job == null)
      {
        throw new Exception("Invalid Id");
      }
      return job;
    }

    public Job Create(Job newjob)
    {
      FAKEDB.Jobs.Add(newjob);
      return newjob;
    }

    public Job Edit(Job editedjob)
    {
      Job job = FAKEDB.Jobs.Find(c => c.Id == editedjob.Id);
      if (job == null)
      {
        throw new Exception("Invalid Id");
      }
      FAKEDB.Jobs.Remove(job);
      FAKEDB.Jobs.Add(editedjob);
      return editedjob;
    }

    public string Delete(string jobId)
    {
      Job job = FAKEDB.Jobs.Find(c => c.Id == jobId);
      if (job == null)
      {
        throw new Exception("Invalid Id");
      }
      FAKEDB.Jobs.Remove(job);
      return "Successfully Deleted";
    }


  }
}