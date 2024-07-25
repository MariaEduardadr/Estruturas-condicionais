using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucro_na_venda_de_produtos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produto, lucro, valorVenda, percentual;
            Console.WriteLine("Digite o valor do produto:");
            produto = double.Parse(Console.ReadLine());
            if (produto < 20.00)
            {
                percentual = 0.45;
                lucro = produto * percentual;
                valorVenda = produto + lucro;
                Console.WriteLine($"Valor da venda {valorVenda}");
            }
            else
            {
                percentual = 0.35;
                lucro = produto * percentual;
                valorVenda = produto + lucro;
                Console.WriteLine($"Valor da venda {valorVenda}");
            }
            Console.ReadLine();
        }
    }
}
