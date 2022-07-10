using System.Collections.Generic;
using System;

namespace Place.Models
{
  public class Place
  {
  public string CityName { get; set; }

  public Place(string cityName)
    {
      CityName = cityName;
    }

  }
}