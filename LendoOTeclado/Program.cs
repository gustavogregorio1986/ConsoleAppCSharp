using System;

namespace LendoOTeclado
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Lendo o tevclado

            string texto; //declarando a variável que recebrá a string dgita

            Console.WriteLine("Digite o texto");
            texto = Console.ReadLine();  //ler o usuário digita
            Console.WriteLine("O valor digitado foi: " + texto);
            Console.WriteLine(texto);
        }
    }
}
