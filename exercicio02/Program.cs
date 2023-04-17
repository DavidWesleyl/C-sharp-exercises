using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro 
        casas decimais conforme exemplos.
        Fórmula da área: area = π . raio2
        Considere o valor de π = 3.14159 */

        System.Console.Write("Digite o valor do raio para calcular a área: ");

        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double PI = 3.14159;

        double calculo = (Math.Pow(raio, 2.0)) * PI;

        System.Console.WriteLine($"O valor da área será: {calculo.ToString("f4", CultureInfo.InvariantCulture)}");








    }
}