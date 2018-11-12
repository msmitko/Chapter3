using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            short wantedDigit = 7;
            int number = int.Parse(Console.ReadLine());
            bool isWantedThirdDigit = ((number / 100) % 10 == wantedDigit
                || (-number / 100) % 10 == wantedDigit);
            Console.WriteLine(isWantedThirdDigit);
        }
    }
}