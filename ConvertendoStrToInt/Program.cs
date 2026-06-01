using System;

namespace ConvertendoStrToInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Convertendo texto em numeros

            string s = "10000";
            int i;

            i = int.Parse(s);

            int x = i + 10; // 10 + 10
            Console.WriteLine(x);

        }
    }
}
