using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondShape
{
    class DiamondShapeEx001
    {
        static void Main(string[] args)
        {
            int row, stars, spaces;

            // top half
            for (row = 1; row <= 5; row++)
            {
                for (spaces = 5; spaces > row; spaces--)
                    Console.Write(" ");

                for (stars = 1; stars <= (2 * row) - 1; stars++)
                    Console.Write("*");

                Console.WriteLine();
            }

            // write code for bottom half here…….
            for (row = 5; row >= 1; row--)
            {
                for (spaces = 5; spaces > row; spaces--)
                    Console.Write(" ");

                for (stars = 1; stars <= (2 * row) - 1; stars++)
                    Console.Write("*");

                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
