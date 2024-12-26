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

            Funcionario func = new Funcionario();

            Console.Write("Digite o nome do funcionário: ");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Salário bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quanto paga de imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine();
            Console.Write("Deseja aumentar o salário em qual porcentagem? ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(porcent);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);



        }
    }
}