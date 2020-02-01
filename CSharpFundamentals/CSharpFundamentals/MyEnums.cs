using System;

namespace CSharpFundamentals
{   public class MyEnums
    {
        /* Enum */
        public enum Season
        {
            Autumn,
            Winter,
            Spring,
            Summer
        }

        public enum ShippingMethod : byte
        /* optional define with custom type, default value is int */
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }
        public static void chooseSeason(Season season)
        {
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Print Autmn");
                    break;

                case Season.Winter:
                    Console.WriteLine("Print Winter");
                    break;

                case Season.Spring:
                    Console.WriteLine("Print Spring");
                    break;

                case Season.Summer:
                    Console.WriteLine("Print Summer");
                    break;

                default:
                    Console.WriteLine("Unknown season");
                    break;
            }

        }
    }
}
