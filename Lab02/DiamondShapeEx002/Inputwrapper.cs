﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondShapeEx002
{
    class Inputwrapper
    {
        public int getInt(string prompt)
        {
            Console.Write(prompt);
            string buf = Console.ReadLine();
            return Convert.ToInt32(buf);
        }

        public double getDouble(string prompt)
        {
            Console.Write(prompt);
            string buf = Console.ReadLine();
            return Convert.ToDouble(buf);
        }

        public decimal getDecimal(string prompt)
        {
            Console.Write(prompt);
            string buf = Console.ReadLine();
            return Convert.ToDecimal(buf);
        }

        public string getString(string prompt)
        {
            Console.Write(prompt);
            string buf = Console.ReadLine();
            return buf;
        }
    }
}
