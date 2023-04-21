using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
         seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
         nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo */


        System.Console.Write("Digite um valor para ver o intervalo: ");

        string[] valor = Console.ReadLine().Split(' ');

        double numero = double.Parse(valor[0], CultureInfo.InvariantCulture);


        if (numero < 0 || numero > 100)
        {
            System.Console.WriteLine("O valor digitado se encontra fora do intervalo! ");
        }

        else if (numero <= 25)
        {
            System.Console.WriteLine("Intervalo [0,25]");
        }

        else if (numero > 25 && numero <= 25.50)
        {
            System.Console.WriteLine("Intervalo [25,50]");
        }

        else if (numero > 25.50 && numero <= 75)
        {
            System.Console.WriteLine("intervalo [50, 75]");
        }

        else if (numero > 75 && numero == 100)
        {
            System.Console.WriteLine("intervalo [75, 100]");
        }












    }
}