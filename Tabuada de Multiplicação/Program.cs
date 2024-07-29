using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada_de_Multiplicação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, tabuada;
            Console.WriteLine("Digite um numero:");
            numero = int.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++)
            {
                tabuada = numero * i;
                Console.WriteLine($"{numero} X {i} = {tabuada}");
            }
            Console.ReadLine();
        }
    }
}
