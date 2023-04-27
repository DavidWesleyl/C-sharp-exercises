using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        /* Digite  um numero e mostre sua Raiz Quadrada com 3 casas  decimais, depois repetir o procedimento. 
        Quando o usuário digitar um numero negativo, mostre "Numero negativo" na tela e encerre o programa */


        System.Console.Write("Digite um numero para ver a raiz quadrada: ");

        double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Vai capturar a Entrada do Usuário





        while (numero >= 0.0) // * loop * > ENQUANTO (numero for maior que 0 )
        {
            double Raiz = Math.Sqrt(numero); // Raiz quadrada do numero

            System.Console.WriteLine($"A raiz quadrada de {numero} é {Raiz.ToString("f3", CultureInfo.InvariantCulture)}"); // Mostre a Raiz

            System.Console.Write("Digite outro numero: "); // Novamente a  pergunta 

            numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Novamente a captura de entrada do usuário

        }

        System.Console.WriteLine("Numero negativo!"); // Se o numero for menor que zero, ou seja, negativo, mostre a mensagem e Encerre.



















    }
}