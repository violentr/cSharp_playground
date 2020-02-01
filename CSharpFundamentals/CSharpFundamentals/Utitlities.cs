using System;
namespace CSharpFundamentals
{
    public class Utilities
    {
        public void myForLoop(int[] array)
        {
            var length = array.Length;
            for (var i = 0; i < length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
