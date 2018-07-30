using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalEx004
{
    class Hotel
    {
        private string city;
        private string name;
        private int noOfRooms;
        private decimal cost;
        private int yearBuilt;
        private int starRating;

        public Hotel(string city, string name, int rooms, decimal cost, int year, string rating)
        {
            City = city;
            Name = name;
            noOfRooms = rooms;
            this.cost = cost;
            yearBuilt = year;
            starRating = rating;
        }

        public void Show()
        {
            Console.WriteLine("{0} {1} {2} {3:C} {4} {5}", City, Name, Rooms, Cost, Year, Rating);
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Rooms
        {
            get { return noOfRooms; }
            set { noOfRooms = value; }
        }

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public int Year
        {
            get { return yearBuilt; }
            set { yearBuilt = value; }
        }

        public int Rating
        {
            get { return starRating; }
            set { starRating = value; }
        }

    }
}
