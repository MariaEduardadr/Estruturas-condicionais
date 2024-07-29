using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cálculo_de_potência
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b, expoente, result = 1, cont = 0;
            Console.WriteLine("Digite o número da base:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            expoente = int.Parse(Console.ReadLine());
            for (int i = 1; i <= expoente; i++)
            {
                result *= b;
                cont++;
            }
            Console.WriteLine($"Resultado da soma {cont}");
            Console.ReadLine();
        }
    }
}
