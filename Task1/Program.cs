using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isEven = number % 2 == 0;
            Console.WriteLine(isEven);
        }
    }
}
