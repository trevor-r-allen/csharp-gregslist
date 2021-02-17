using System;
using System.ComponentModel.DataAnnotations;

namespace csharp_gregslist.Models
{
  public class Job
  {
    public Job(string company, string jobTitle, int hours, int rate, string description)
    {
      this.Company = company;
      this.JobTitle = jobTitle;
      this.Hours = hours;
      this.Rate = rate;
      this.Description = description;
    }

    [Required]
    public string Company { get; set; }
    [Required]
    public string JobTitle { get; set; }
    [Required]
    public int Hours { get; set; }
    [Required]
    public int Rate { get; set; }
    [MaxLength(144)]
    public string Description { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString();
  }
}