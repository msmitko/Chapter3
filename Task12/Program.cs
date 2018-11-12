using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            bool isBitOne = (v >> p & 1) == 1;
            Console.WriteLine(isBitOne);
        }
    }
}

