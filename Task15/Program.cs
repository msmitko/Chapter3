using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            uint mask3b4b5b = (1 << 3) | (1 << 4) | (1 << 5);
            uint mask24b25b26b = (1 << 24) | (1 << 25) | (1 << 26);

            uint subBits3b4b5b = number & mask3b4b5b;
            uint subBits24b25b26b = number & mask24b25b26b;

            number = (~mask24b25b26b & number) | (subBits3b4b5b << 21);
            number = (~mask3b4b5b & number) | (subBits24b25b26b >> 21);

            Console.WriteLine(number);
        }
    }
}
