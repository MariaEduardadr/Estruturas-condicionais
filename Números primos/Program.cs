using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Números_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"Números que são primos: {i}");
                }
            }

            Console.ReadLine();
        }
    }
}