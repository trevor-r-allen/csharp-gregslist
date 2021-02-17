using System;
using System.Collections.Generic;
using csharp_gregslist.DB;
using csharp_gregslist.Models;

namespace csharp_gregslist.Services
{
  public class HousesService
  {
    public IEnumerable<House> Get()
    {
      return FAKEDB.Houses;
    }

    public House Get(string houseId)
    {
      House house = FAKEDB.Houses.Find(c => c.Id == houseId);
      if (house == null)
      {
        throw new Exception("Invalid Id");
      }
      return house;
    }

    public House Create(House newhouse)
    {
      FAKEDB.Houses.Add(newhouse);
      return newhouse;
    }

    public House Edit(House editedhouse)
    {
      House house = FAKEDB.Houses.Find(c => c.Id == editedhouse.Id);
      if (house == null)
      {
        throw new Exception("Invalid Id");
      }
      FAKEDB.Houses.Remove(house);
      FAKEDB.Houses.Add(editedhouse);
      return editedhouse;
    }

    public string Delete(string houseId)
    {
      House house = FAKEDB.Houses.Find(c => c.Id == houseId);
      if (house == null)
      {
        throw new Exception("Invalid Id");
      }
      FAKEDB.Houses.Remove(house);
      return "Successfully Deleted";
    }


  }
}