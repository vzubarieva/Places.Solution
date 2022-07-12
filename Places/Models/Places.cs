using System.Collections.Generic;
using System;

namespace Places.Models
{
    public class Place
    {
        public string CityName { get; set; }
        private static List<Place> _instances = new List<Place> { };

        public Place(string cityName)
        {
            CityName = cityName;
            _instances.Add(this);
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }
    }
}
