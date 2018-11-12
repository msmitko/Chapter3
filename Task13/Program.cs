using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());

            int mask = ~(1 << p);
            int bitChanger = v << p;

            n = (n & mask) | bitChanger;

            Console.WriteLine(n);
        }
    }
}
