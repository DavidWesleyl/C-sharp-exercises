using System;
using System.Globalization;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            // MÉDIA PONDERADA 
            
            
            Console.Write("Quantas médias você quer calcular?: ");

            int valores = int.Parse(Console.ReadLine());


            for(int inicio = 0; inicio < valores; inicio++)
            {
                Console.Write(">> Digite os valores (mesma linha): ");
                
                string[] numeros = Console.ReadLine().Split(' ');
                
                double num1 = double.Parse(numeros[0], CultureInfo.InvariantCulture);
                double num2 = double.Parse(numeros[1], CultureInfo.InvariantCulture);
                double num3 = double.Parse(numeros[2], CultureInfo.InvariantCulture);


                double Media = (num1 * 2.0 + num2 * 3.0 + num3 * 5.0) / 10.0; // Primeiro peso: 2, Segundo Peso 3, Terceiro peso: 5

                Console.WriteLine(" ");
                Console.WriteLine($"A Média do valor foi {Media.ToString("f1", CultureInfo.InvariantCulture)}");




            }









        }
    }
}