using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progressão_Aritmética
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, numero, razao;
            Console.WriteLine("Digite um termo:");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a razão:");
            razao = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                soma = numero + i * razao;
            }
            Console.WriteLine($"Progressão Aritmética: {soma}");
            Console.ReadLine();
        }
    }
}


