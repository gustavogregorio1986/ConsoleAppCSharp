using System;

namespace MiniCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Simples calculadora
            /*
            double d;

            d = 12 + 3;  // soma (+)
            d = 12 - 3; // subtração (-)
            d = 12 * 3; // multiplicação (x)
            d = 12 / 3; // divisão (/)
            Console.WriteLine(d);
            */

            double num1, num2;
            string tmp;

            Console.WriteLine("Digite um numero: ");
            tmp = Console.ReadLine();
            num1 = double.Parse(tmp);

            Console.WriteLine("Digite mais um numero: ");
            tmp = Console.ReadLine();
            num2 = double.Parse(tmp);

            double resultado = num1 + num2;

            Console.WriteLine("Soma: " + resultado);

            resultado = num1 - num2;

            Console.WriteLine("Subtracao: " + resultado);

            resultado = num1 * num2;

            Console.WriteLine("Multiplicacao: " + resultado);

            resultado = num1 / num2;

            Console.WriteLine("Divisao: " + resultado);

        }
    }
}
