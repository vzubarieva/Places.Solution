using Microsoft.VisualStudio.TestTools.UnitTesting;
using Places.Models;
using System.Collections.Generic;
using System;

namespace Places.Tests
{
    [TestClass]
    public class PlaceTests : IDisposable
    {
        public void Dispose()
        {
            Place.ClearAll();
        }

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

        [TestMethod]
        public void SetCityName_SetCityName_String()
        {
            //Arrange
            string cityName = "Seattle";
            Place newPlace = new Place(cityName);

            //Act
            string updatedCityName = "Portland";
            newPlace.CityName = updatedCityName;
            string result = newPlace.CityName;

            //Assert
            Assert.AreEqual(updatedCityName, result);
        }

        [TestMethod]
        public void GetAll_ReturnsEmptyList_PlaceList()
        {
            // Arrange
            List<Place> newList = new List<Place> { };

            // Act
            List<Place> result = Place.GetAll();

            // Assert
            CollectionAssert.AreEqual(newList, result);
        }

        [TestMethod]
        public void GetAll_ReturnsPlaces_PlaceList()
        {
            //Arrange
            string cityName01 = "Seattle";
            string cityName02 = "Portland";
            Place newPlace1 = new Place(cityName01);
            Place newPlace2 = new Place(cityName02);
            List<Place> newList = new List<Place> { newPlace1, newPlace2 };

            //Act
            List<Place> result = Place.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }
    }
}
