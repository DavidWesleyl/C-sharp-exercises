using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {

        /* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
         segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel". */



        Console.Write("Digite a quantidade de divisões que você quer fazer: ");

        int quantidade = int.Parse(Console.ReadLine());


        for (int inicio = 1; inicio <= quantidade; inicio++)
        
        {
            Console.Write("Digite os valores (mesma linha): ");

            string[] valores = Console.ReadLine().Split(' ');

            double num1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double num2 = double.Parse(valores[1], CultureInfo.InvariantCulture);

            double divisao = num1 / num2;

            if (num1 > 0 && num2 == 0 || num1 < 0 && num2 == 0)
            
            {
                
                Console.WriteLine("Divisão impossível.");
            
            }
            
            else
            
            {
                
                Console.WriteLine(divisao.ToString("f1", CultureInfo.InvariantCulture));
            
            }














        }





















    }
}