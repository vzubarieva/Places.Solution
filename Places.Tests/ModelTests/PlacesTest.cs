using Microsoft.VisualStudio.TestTools.UnitTesting;
using Place.Models;
using System.Collections.Generic;
using System;

namespace Place.Tests
{
  [TestClass]
  public class Place
  {
[TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place newPlace = new Place("test"); 
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }

    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      //Arrange
      string cityName = "Seattle";
      Place newPlace = new Place(cityName);

      //Act
      string result = newPlace.CityName;

      //Assert
      Assert.AreEqual(cityName, result);
    }
  }
}