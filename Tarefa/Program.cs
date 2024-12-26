using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Teste;


namespace Course
{
    class Program
    {
        static void Main(String[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto : ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Dados do produto : " + p);
            
            Console.Write("Digite a quantidade para ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados do produto : " + p);

            Console.Write("Digite a quantidade para ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados do produto : " + p);







        }
    }
}