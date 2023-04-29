using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema 
        cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo 
        menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma)*/

        /* exemplo: 
        
            2, 2 = Primeiro 
            3, -2 = Quarto 
            -7, 1 = Segundo
            -8, -1 = Terceiro
            0, 2 = Nulo          */


        System.Console.Write("Digite os valores para saber em que Quadrante ele se encontra: ");

        string[] Quadrantes = Console.ReadLine().Split(' ');

        double valor01 = double.Parse(Quadrantes[0]);
        double valor02 = double.Parse(Quadrantes[1]);

        System.Console.WriteLine($"Valores: {valor01},{valor02}");

        while (valor01 != 0 && valor02 != 0)
        {
            if (valor01 > 0 && valor02 > 0)
            {
                System.Console.WriteLine(">> Primeiro Quadrante");

            }

            else if (valor01 > 0 && valor02 < 0)
            {
                System.Console.WriteLine(">> Quarto Quadrante");

            }

            else if (valor01 < 0 && valor02 > 0)

            {
                System.Console.WriteLine(">> Segundo Quadrante!");

            }

            else if (valor01 < 0 && valor02 < 0)
            {
                System.Console.WriteLine("Terceiro Quadrante!");

            }

            System.Console.WriteLine(" ");

            System.Console.Write("Digite outro valor: ");
            Quadrantes = Console.ReadLine().Split(' ');
            valor01 = double.Parse(Quadrantes[0]);
            valor02 = double.Parse(Quadrantes[1]);


        }







    }
}