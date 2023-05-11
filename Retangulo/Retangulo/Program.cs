using Retangulo;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        /* Fazer um programa para ler os valores da largura e altura de um retângulo. Em 
           seguida, mostrar na tela o valor de sua área, perímetro e diagonal. */

        /* Neste exercicio foi criada uma Classe chamada CalculoRetangulo, onde recebe 2 atributos (Altura, Largura) 
           e foram criados 3 métodos para calcular Àrea, Perímetro e Largura */


        CalculoRetangulo valores;

        valores = new CalculoRetangulo();

        Console.WriteLine("Digite a altura e largura do Retangulo, abaixo: ");
        valores.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        valores.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine($"Area = {(valores.Area()).ToString("f2", CultureInfo.InvariantCulture)}");

        Console.WriteLine();
        Console.WriteLine($"Perimetro = {(valores.Perimetro()).ToString("f2", CultureInfo.InvariantCulture)}");

        Console.WriteLine();
        Console.WriteLine($"Largura = {valores.Diagonal()}");











    }
}