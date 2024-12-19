using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(String[] args)
        {


            Console.Write("Quantos números inteiros voce vai digitar : ");
            int n = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("valor :#{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;



            }

            Console.WriteLine("soma é igual " +soma);








        }
    }
}
