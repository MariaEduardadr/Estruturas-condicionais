using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cáculo_IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double imc, peso, altura;
            Console.WriteLine("Digite seu peso:");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua altura:");
            altura = double.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc < 24.9)
            {
                Console.WriteLine("Saudável");
            }
            else if (imc < 29.9)
            {
                Console.WriteLine("Peso em execesso");
            }
            else if (imc < 34.9)
            {
                Console.WriteLine("Obesidade grau I");
            }
            else if (imc < 39.9)
            {
                Console.WriteLine("Obesidade grau II servera");
            }
            else
            {
                Console.WriteLine("Obsidade grau III mórbida");
            }
            Console.ReadLine();
        }
    }
}
