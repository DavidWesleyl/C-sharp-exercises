using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
        hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas 
        decimais */

        System.Console.Write("Digite o numero do Funcionário: ");

        int numero_do_funcionario = int.Parse(Console.ReadLine());


        System.Console.Write("Quantas horas trabalhadas?: ");

        int horas_trabalhadas = int.Parse(Console.ReadLine());


        System.Console.Write("Quanto o funcionário ganha por hora? R$ ");

        double ganho_hora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        double calculo = ganho_hora * horas_trabalhadas;

        System.Console.WriteLine(" ");

        System.Console.WriteLine($" O funcionário num {numero_do_funcionario}, ganha aproximadamente R$ {calculo.ToString("f2", CultureInfo.InvariantCulture)}");



    }
}