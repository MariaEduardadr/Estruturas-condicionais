using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_dívisiveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("Digite um número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número:");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("os números que são divisíveis por 2 e por 3:");
            if (n1 % 2 == 0 && n1 % 3 == 0)
            {
                Console.WriteLine(n1);
            }
            if (n2 % 2 == 0 && n2 % 3 == 0)
            {
                Console.WriteLine(n2);
            }
            if (n3 % 2 == 0 && n3 % 3 == 0)
            {
                Console.WriteLine(n3);
            }
            if (n4 % 2 == 0 && n4 % 3 == 0)
            {
                Console.WriteLine(n4);
            }
            Console.ReadLine();
        }
    }
}
