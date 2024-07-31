using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisores_de_um_número
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"Os divisores de {numero} são:");
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    Console.Write(i + ",");
                }
            }
            Console.ReadLine();
        }
    }
}
