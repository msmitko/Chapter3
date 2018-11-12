using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int abcd = int.Parse(Console.ReadLine());
            int a = abcd / 1000;
            int b = abcd / 100 % 10;
            int c = abcd / 10 % 10;
            int d = abcd % 10;

            int digitsSum = a + b + c + d;
            Console.WriteLine(digitsSum);

            Console.WriteLine("{0}{1}{2}{3}", d, c, b, a);

            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);

            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }
    }
}
