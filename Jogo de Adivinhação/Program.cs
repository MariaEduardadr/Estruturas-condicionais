using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Adivinhação
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int aleatoriamente = r.Next(1, 100), cont = 0, num;
            bool teste = true;
            while (cont != 5)
            {
                Console.WriteLine("Digite um número:");
                num = int.Parse(Console.ReadLine());
                if (num > aleatoriamente)
                {
                    Console.WriteLine("Menor");
                }
                else if (num < aleatoriamente)
                {
                    Console.WriteLine("Maior");
                }
                else
                {
                    Console.WriteLine("Acertou!");
                    teste = false;
                }
                cont++;
            }
            if (teste == true)
            {
                Console.WriteLine("Você Atingiu as 5 tentativas.");
            }
            Console.ReadLine();
        }
    }
}
