using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificação_de_estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numIntens, intensFornecidos, novoEstoque;
            Console.WriteLine("Informe a quantidade de intens em estoque:");
            numIntens = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o número de itens a serem fornecidos:");
            intensFornecidos = int.Parse(Console.ReadLine());
            if (numIntens >= intensFornecidos)
            {
                novoEstoque = numIntens - intensFornecidos;
                Console.WriteLine($"Estque atualizado {novoEstoque}");
            }
            else
            {
                Console.WriteLine("Não haver intens suficientes em estoque para atender o pedido");
            }
            Console.ReadLine();
        }
    }
}
