using System;
using System.ComponentModel.DataAnnotations;

namespace csharp_gregslist.Models
{
  public class House
  {
    public House(int bedrooms, int bathrooms, int levels, int year, int price, string description, string imageUrl)
    {
      this.Bedrooms = bedrooms;
      this.Bathrooms = bathrooms;
      this.Levels = levels;
      this.Year = year;
      this.Price = price;
      this.Description = description;
      this.ImageUrl = imageUrl != null ? imageUrl : "http://placehold.it/200x200";
    }

    [Required]
    public int Bedrooms { get; set; }
    [Required]
    public int Bathrooms { get; set; }
    [Required]
    public int Levels { get; set; }
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