using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Série_Numérica_Específica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, impar = 1, par = 4;
            Console.WriteLine("Dgite o valor de N:");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(impar + " ");
                    if (i % 2 == 1)
                    {
                        impar++;
                    }
                }
                else
                {
                    Console.Write(impar + " ");
                    if (i % 2 == 0)
                    {
                        par++;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
