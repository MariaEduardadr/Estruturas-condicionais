using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_Média_das_Notas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0, cont = 0, media, nota;
            bool teste = true;
            while (teste == true)
            {
                Console.WriteLine($"Informe uma nota:");
                nota = int.Parse(Console.ReadLine());
                if (nota > 0)
                {
                    soma += nota;
                    cont++;
                    teste = true;
                }
                else
                {
                    teste = false;
                }
            }
            media = soma / cont;
            Console.WriteLine($"Média das notas de alunos: {media}");
            Console.ReadLine();
        }
    }
}

