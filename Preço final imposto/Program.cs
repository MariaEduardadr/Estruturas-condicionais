using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preço_final_imposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double preco, taxa, valorImposto, valorFinal; string estado;
            Console.WriteLine("Digite o preço do produto:");
            preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sigla do estado:");
            estado = Console.ReadLine();
            if (estado == "MG")
            {
                taxa = 0.7;
                valorImposto = preco * (taxa / 100);
                valorFinal = valorImposto + preco;
                Console.WriteLine($"Preço final do produto acrescido do estado MG: {valorFinal}");
            }
            else if (estado == "SP")
            {
                taxa = 0.12;
                valorImposto = preco * (taxa / 100);
                valorFinal = valorImposto + preco;
                Console.WriteLine($"Preço final do produto acrescido do estado SP: {valorFinal}");
            }
            else if (estado == "RJ")
            {
                taxa = 0.15;
                valorImposto = preco * (taxa / 100);
                valorFinal = valorImposto + preco;
                Console.WriteLine($"Preço final do produto acrescido do estado RJ: {valorFinal}");
            }
            else if (estado == "MS")
            {
                taxa = 0.8;
                valorImposto = preco * (taxa / 100);
                valorFinal = valorImposto + preco;
                Console.WriteLine($"Preço final do produto acrescido do estado MS: {valorFinal}");
            }
            else
            {
                Console.WriteLine("Estado inválido");
            }
            Console.ReadLine();
        }
    }
}
