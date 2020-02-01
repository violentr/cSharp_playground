using System;
namespace CSharpFundamentals
{
    public class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("My name is {0} {1}", firstName, lastName);
        }

    }
}
