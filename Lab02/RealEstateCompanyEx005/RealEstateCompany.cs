using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCompanyEx005
{
    class RealEstateCompany
    {
        /*ToDo: 
         * This validation makes assumption for user input, 
         * how would you be able to improve this validation 
         * to ensure that user input is within range for enmu values 
        */
        public enum HouseType { SingleFamily = 1, Townhouse, lifestyle_block}
        public const HouseType MyHEnum_Min = HouseType.SingleFamily;
        public const HouseType MyHEnum_Max = HouseType.lifestyle_block;
        //Garage
        public enum GarageType { Single = 1, Double, threeCarPlus, Carport, Not_essential}
        public const GarageType MyGEnum_Min = GarageType.Single;
        public const GarageType MyGEnum_Max = GarageType.Not_essential;

        public static void Main(string[] args)
        {
            //while ()
            {
                try
                {
                    HouseType hType = 0;
                    Console.Write(@"Enter the type of house you want to purchase
0 - Default
1 - Single Family
2 - Townhouse
3 - lifestyle block
your Choice: ");

                    hType = Validate((HouseType)int.Parse(Console.ReadLine()));

                    Console.WriteLine("\nGreat, you choice was: {0}", hType);
                    
                    
                }
                catch (System.ArgumentException)
                {
                    Console.WriteLine("Invaild input, has to be between 0 - 3");
                    
                }
                //Garage
                GarageType gType = 0;
                Console.Write(@"Enter type of Garage you want to purchase
0 - Default
1 - Single
2 - Double
3 - 3 Car +
4 - Carport
5 - Not essential
your Choice: ");

                gType = Validate((GarageType)int.Parse(Console.ReadLine()));

                Console.WriteLine("\nGreat, you choice was: {0}", gType);

                Console.Read();
            }
        }
        public static HouseType Validate(HouseType value)
        {
            if (value < MyHEnum_Min) return MyHEnum_Min;
            if (value > MyHEnum_Max) return MyHEnum_Max;
            return value;
        }
        public static GarageType Validate(GarageType value)
        {
            if (value < MyGEnum_Min) return MyGEnum_Min;
            if (value > MyGEnum_Max) return MyGEnum_Max;
            return value;
        }

    }
    
}

