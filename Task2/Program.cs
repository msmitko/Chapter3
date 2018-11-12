using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isDiveded = (number % 5 == 0) && (number % 7 == 0);
            Console.WriteLine(isDiveded);
        }
    }
}
