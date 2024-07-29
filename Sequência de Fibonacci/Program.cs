using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Sequência_de_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, n1 = 1, n2 = 1, proximo;
            Console.WriteLine("Digite a quantidade de (N) elementos:");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Os primeiros elementos da sequência de Fibonacci são {n1}, {n2}");
            for (int i = 2; i < n; i++)
            {
                proximo = n1 + n2;
                Console.Write($"{proximo} ,");
                n1 = n2;
                n2 = proximo;
            }
            Console.ReadLine();
        }
    }
}
