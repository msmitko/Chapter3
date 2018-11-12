using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int thirdBit = (number >> 3) & 1;
            Console.WriteLine(thirdBit);
        }
    }
}