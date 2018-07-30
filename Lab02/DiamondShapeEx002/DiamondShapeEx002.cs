using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondShapeEx002
{
    class DiamondShapeEx002
    {
        static void Main(string[] args)
        {
            Inputwrapper iw = new Inputwrapper();
            Console.WriteLine("Enter Diamond Size eg1 to 10");
            int size = iw.getInt("Enter: ");

            

            
                int stars, row, spaces;
            
                // top half
                for (row = 1; row <= size; row++)
                {
                    for (spaces = size; spaces > row; spaces--)
                        Console.Write(" ");

                    for (stars = 1; stars <= (2 * row) - 1; stars++)
                        Console.Write("*");

                    Console.WriteLine();
                }

                // write code for bottom half here…….
                for (row = size -1; row >= 1; row--)
                {
                    for (spaces = size; spaces > row; spaces--)
                        Console.Write(" ");

                    for (stars = 1; stars <= (2 * row) - 1; stars++)
                        Console.Write("*");

                    Console.WriteLine();
                }
                Console.Read();
            
            
            
            
        }
    }
}
