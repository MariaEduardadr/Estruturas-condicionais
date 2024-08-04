using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operações_com_Vetores__x_e_y_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            int[] y = new int[5];
            int[] soma = new int[5];
            int[] produto = new int[5];
            int[] diferenca = new int[5];
            int[] intersecao = new int[5];
            int[] uniao = new int[10];
            Console.WriteLine("Vetor X");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"Digite um valor na posição {i}:");
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Vetor Y");
            for (int i = 0; i < y.Length; i++)
            {
                Console.WriteLine($"Digite um valor na posição {i}:");
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Soma");
            for (int i = 0; i < soma.Length; i++)
            {
                soma[i] = x[i] + y[i];
                Console.WriteLine($"Soma entre {x[i]} + {y[i]} = {soma[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Produto");
            for (int i = 0; i < produto.Length; i++)
            {
                produto[i] = x[i] * y[i];
                Console.WriteLine($"Soma entre {x[i]} X {y[i]} = {soma[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("Diferença entre X e Y");
            for (int i = 0, j = 0; i < diferenca.Length; i++, j++)
            {
                if (x[i] != y[j])
                {
                    Console.WriteLine($"{x[i]} e {y[j]}");
                }

            }
            Console.WriteLine();
            Console.WriteLine("Interseção");
            for (int i = 0; i < intersecao.Length; i++)
            {
                for (int j = 0; j < intersecao.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        Console.WriteLine($"x {x[i]} e y {y[j]}");
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("União de vetores");
            int cont = 0, contx = 0, conty = 0;
            for (int i = 0, j = 0; i < 5; i++, j++)
            {
                if (x[i] != y[j])
                {
                    cont++;
                }
            }
            for (int i = 0, j = 0; j < cont; i += 2, j++)
            {
                if (x[contx] != y[conty])
                {
                    uniao[i] = x[j];
                    uniao[i + 1] = y[j];
                }
                contx++;
                conty++;
            }


            Console.ReadLine();
        }
    }
}
