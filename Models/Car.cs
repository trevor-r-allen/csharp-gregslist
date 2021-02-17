using System;
using System.ComponentModel.DataAnnotations;

namespace csharp_gregslist.Models
{
  public class Car
  {
    public Car(string make, string model, int year, int price, string description, string imageUrl)
    {
      this.Make = make;
      this.Model = model;
      this.Year = year;
      this.Price = price;
      this.Description = description;
      this.ImageUrl = imageUrl != null ? imageUrl : "http://placehold.it/200x200";

    }

    [Required]
    public string Make { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    [Range(1940, 2022)]
    public int Year { get; set; }
    [Required]
    public int Price { get; set; }
    [MaxLength(144)]
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public string Id { get; set; } = Guid.NewGuid().ToString();

  }
}