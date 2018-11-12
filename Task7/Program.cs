using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            double earthWeigth = double.Parse(Console.ReadLine());
            double moonWeigth = 0.17 * earthWeigth;
            Console.WriteLine(moonWeigth);
        }
    }
}
