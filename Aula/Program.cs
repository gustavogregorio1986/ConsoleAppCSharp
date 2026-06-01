using System;

namespace Aula
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int num = 0;

            //Console.WriteLine("Digite um numero: ");
            //string str = Console.ReadLine();
            //num = Convert.ToInt32(str);

            //if(num > 0)
            //{
            //    Console.WriteLine("O numero digitado é positivo");
            //}

            int num = 0;
            string texto = "O número digoitado é: ";
            Console.WriteLine("Digite um número qualquer: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num > 0)
                Console.WriteLine(texto + " positivo");
             if(num < 0)
                Console.WriteLine(texto + "negativo"); 
            }
        }
    }

