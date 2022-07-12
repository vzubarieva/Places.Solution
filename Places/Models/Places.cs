using System.Collections.Generic;
using System;

namespace Places.Models
{
    public class Place
    {
        public string CityName { get; set; }
        public int Id { get; }
        private static List<Place> _instances = new List<Place> { };

        public Place(string cityName)
        {
            CityName = cityName;
            _instances.Add(this);
            Id = _instances.Count;
        }

        public static List<Place> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Place Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }

    public class DetailVariable
    {
        public string CityName { get; set; }
        public int Arrival { get; set; }
        public int Departure { get; set; }
        public string Friend { get; set; }
    }
}
