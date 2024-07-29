using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversão_de_temperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit, celsius;
            for (celsius = 0; celsius <= 100; celsius++)
            {
                fahrenheit = (celsius * 9 / 5) + 32;
                Console.WriteLine($"O valor em Celsius {celsius} convertido para Fahrenheit {fahrenheit}");
            }
            Console.ReadLine();
        }
    }
}

