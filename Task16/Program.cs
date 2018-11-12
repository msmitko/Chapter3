using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            byte p = byte.Parse(Console.ReadLine());
            byte q = byte.Parse(Console.ReadLine());
            byte k = byte.Parse(Console.ReadLine());

            uint maskP = new uint();
            uint maskQ = new uint();
            for (int i = 0; i <= k; i++)
            {
                maskP = maskP | (uint)(1 << (p + i));
                maskQ = maskQ | (uint)(1 << (q + i));
            }

            uint subBitsP = number & maskP;
            uint subBitsQ = number & maskQ;

            number = (~maskQ & number) | (subBitsP << q - p);
            number = (~maskP & number) | (subBitsQ >> q - p);

            Console.WriteLine(number);
        }
    }
}
