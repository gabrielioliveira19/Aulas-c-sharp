using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;




            Console.WriteLine("Informo o ano:");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine();



            if ((ano % 4 == 0 && ano % 100 != 0) || (ano % 400 == 0))
            {
                Console.WriteLine("é bissexto:");
            }

            else
                Console.WriteLine("Não é bissexto:");

        }
    }
}
