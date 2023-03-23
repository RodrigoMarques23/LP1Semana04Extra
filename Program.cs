using System;

namespace testrepo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("How are you?");
            Console.WriteLine("Hello stranger!");
            SomeFunction();
        }

        private static void SomeFunction()
        {
            Console.WriteLine("Byez");
        }
    }
}
