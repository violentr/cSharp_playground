using System;
namespace CSharpFundamentals
{
    public class Utilities
    {
        public static void myForLoop(int[] array)
        {
            var length = array.Length;
            for (var i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void myForEachLoop(int[] array)
        {
            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
