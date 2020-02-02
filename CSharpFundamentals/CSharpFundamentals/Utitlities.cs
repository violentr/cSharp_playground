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
        public static void generatePassword()
        {
          const int passwordLength = 10;

          var buffer = new char[passwordLength];
          for (var i=0; i<passwordLength; i++)
          {
            var random = new Random();
            // Console.WriteLine((char)('a' + random.Next(1, 10)));
            buffer[i] = (char)('a' + random.Next(0, 26));
           
          }
          Console.WriteLine(string.Format("Generated password: {0}\n", new string(buffer)));
        }
    }
}
