using SalarioMedio;
using System;
using System.Globalization;
using System.Net;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {

        /* Fazer um programa para ler nome e salário de dois funcionários.Depois, mostrar o salário
       médio dos funcionários. */

        // Nesse exercicio foi criada uma Classe chamada "Salario" onde recebe apenas um atributo -> Public double MediaSalarial; <-


        Salario PrimeiroValor, SegundoValor;

        PrimeiroValor = new Salario();
        SegundoValor = new Salario();



        Console.WriteLine("DADOS DO PRIMEIRO FUNCIONÁRIO ");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine(" ");

        Console.Write("Nome: ");
        string PrimeiroFuncionario = Console.ReadLine();


        Console.Write("Salário: ");
        PrimeiroValor.Media_Salarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(" ");

        Console.WriteLine("DADOS DO SEGUNDO FUNCIONÁRIO ");
        Console.WriteLine("------------------------------------");
        Console.WriteLine(" ");

        Console.Write("Nome: ");
        string SegundoFuncionario = Console.ReadLine();

        Console.Write("Salário: ");
        SegundoValor.Media_Salarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Console.WriteLine(" ");

        double media = (PrimeiroValor.Media_Salarial + SegundoValor.Media_Salarial) / 2.0;



        Console.WriteLine($"Média salarial {media.ToString("f2", CultureInfo.InvariantCulture)}");


























    }
}