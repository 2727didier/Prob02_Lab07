using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob02_Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"Divisor de Omar Orlandini {contador}: {i}");
                    contador++;
                }
            }
        }
    }

}
