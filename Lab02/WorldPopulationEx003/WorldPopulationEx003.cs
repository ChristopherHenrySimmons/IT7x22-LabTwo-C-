using DiamondShapeEx003;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldPopulationEx003
{
    class WorldPopulationEx003
    {
        static void Main(string[] args)
        {
            Inputwrapper iw = new Inputwrapper();

            double annualPopIncrease;
            double estimatedPop;
            //Calculate world population growth each year till 75 years

            int currentPop = iw.getInt("Current World Poplulation: ");
            decimal growthRate = iw.getDecimal("Current Growth Rate % (e.g, 2.0 for 2%): ");

            int anticipatedWorldPoplulation;
            for (int count = 0; count <= 75; count++)
            {
                annualPopIncrease = ((growthRate / 100) * currentPop)) * count;
                estimatedPop = currentPop + annualPopIncrease;
            }


        }
    }
}
