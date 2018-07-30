using DiamondShapeEx003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotalEx004;

namespace HotalEx004
{
    class testHotel
    {
        private static void Main(string[] args)
        {
            Inputwrapper iw = new Inputwrapper();
            Hotel hotel = new Hotel();

            City = iw.getString("City: ");
            Name = iw.getString("Name: ");
            Rooms = iw.getInt("Number of Rooms: ");
            Cost = iw.getDecimal("Cost: ");
            Year = iw.getInt("Year: ");
            Rating = iw.getInt("Star Rating: ");

            Console.WriteLine(Show());
        }
    }
}
