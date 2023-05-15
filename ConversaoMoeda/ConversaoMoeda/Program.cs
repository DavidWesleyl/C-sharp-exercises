using ConversaoMoeda;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Faça um programa para ler a cotação do Dolar e depois um valor em dolares a ser comprado em reais.
         * Informe quantos reais a pessoa vai pagar pelos dolares, considerando ainda que a pessoa terá que pagar 6% de IOF 
         sobre o valor en dolar. OBS: Crie uma classe para calcular */

        
        // Comentário: Neste exercicios  foi usado métodos estáticos.

        // Como estamos usando Métodos estáticos (Static), não precisamos instanciar a Classe. Podemos chama-lá direto.

        Console.Write("Qual é a cotação do Dolar: ");
        Dolar.ValorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();

        Console.Write("Quanto em dolar você vai comprar? ");
        Dolar.Quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine($"Valor a ser pago em reais = R$ {Dolar.Total().ToString("f2", CultureInfo.InvariantCulture)}");


























    }
}