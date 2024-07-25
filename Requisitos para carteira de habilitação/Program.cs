using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requisitos_para_carteira_de_habilitação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, tempo; char tipoHabilitacao;
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo de habilitação:");
            tipoHabilitacao = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tempo que você possui de habilitação:");
            tempo = int.Parse(Console.ReadLine());
            if (idade >= 21 && tipoHabilitacao == 'B' && tempo >= 2)
            {
                Console.WriteLine("Você possui requisitos necessários para tirar habilitação do tipo D");
            }
            else if (idade >= 21 && tipoHabilitacao == 'C' && tempo >= 1)
            {
                Console.WriteLine("Você possui requisitos necessários para tirar habilitação do tipo D");
            }
            else if (idade < 21)
            {
                Console.WriteLine("Você não possui idade necessária para tirar habilitação do tipo D");
            }
            else if (tipoHabilitacao != 'C' && tipoHabilitacao != 'B')
            {
                Console.WriteLine("Você não possui o tipo de habilitação necessária.");
            }
            else
            {
                Console.WriteLine("Você não possui tempo necessário para tirar habilitação do tipo D");
            }
            Console.ReadLine();
        }
    }
}
