using System;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.firstName = "John";
            p.lastName = "Smith";
            p.Introduce();

            /* Array */
            var numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            Console.WriteLine("{0} {1}", numbers[0], numbers[1]);
            Console.WriteLine(numbers[2]); //not initialized -> defaults to 0

            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]); //not initialized -> defaults to false
            var names = new string[3] { "Jack", "James", "Jany" };
            Console.WriteLine("Name: ", names[1]);
            //Console.WriteLine(names[3]);// will raise an exception

            /* Enum */
            var methodName = "Express";
            var s = (MyEnums.ShippingMethod)Enum.Parse(typeof(MyEnums.ShippingMethod), methodName);
            Console.WriteLine("shippingMethod id is {0}", (int)s);

            /* control flow */
            var season = MyEnums.Season.Winter;
            MyEnums.chooseSeason(season);
            var hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (hour > 12 && hour < 18)
            {
                Console.WriteLine("Good afternoon");
            }
            else
            {
                Console.WriteLine("Good evening");
            }

            /* Loops */
            const int count = 7;
            var list = new int[count] { 1, 2, 3, 4, 5, 6, 7 };
            Utilities.myForLoop(list);
            Utilities.myForEachLoop(list);
        }
        
    }
}
                