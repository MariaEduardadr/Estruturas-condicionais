using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_do_Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, fatorial;
            Console.WriteLine("Digite um número:");
            n = int.Parse(Console.ReadLine());
            for (fatorial = 1; n > 1; n = n - 1)
            {
                fatorial = fatorial * n;
            }
            Console.WriteLine($"Soma Fatorial: {fatorial}");
            Console.ReadLine();
        }
    }
}
