using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_por_Extenso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite um número:");
            numero = int.Parse(Console.ReadLine());
            if (numero == 0)
            {
                Console.WriteLine("ZERO");
            }
            else if (numero == 1)
            {
                Console.WriteLine("UM");
            }
            else if (numero == 2)
            {
                Console.WriteLine("DOIS");
            }
            else if (numero == 3)
            {
                Console.WriteLine("TRÊS");
            }
            else if (numero == 4)
            {
                Console.WriteLine("QUATRO");
            }
            else if (numero == 5)
            {
                Console.WriteLine("CINCO");
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
            Console.ReadLine();
        }
    }
}
/*Escreva um programa que leia um número entre 0 e 5 e imprima o valor lido por extenso (ex: “Cinco”),
se o número estiver fora dessa faixa imprima “Valor inválido”*/