internal class Program
{
    private static void Main(string[] args)
    {
        /* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o 
        código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago */


        System.Console.Write("1.0 >> Digite: O código da peça, o número de peças e o valor unitário (mesma linha): ");

        string[] pecas_1 = Console.ReadLine().Split(' ');

        int codigo01 = int.Parse(pecas_1[0]);

        int numero_pecas = int.Parse(pecas_1[1]);

        double valor_1 = double.Parse(pecas_1[2]);



        System.Console.Write("2.0 >> Digite o código da peça, o número de peças e o valor unitário (mesma linha): ");

        string[] pecas_2 = Console.ReadLine().Split(' ');

        int codigo02 = int.Parse(pecas_2[0]);

        int numero_pecas2 = int.Parse(pecas_2[1]);

        double valor_2 = double.Parse(pecas_2[2]);


        double calculo = (numero_pecas * valor_1) + (numero_pecas2 * valor_2);

        System.Console.WriteLine(" ");
        System.Console.WriteLine($"Valor a pagar: R$ {calculo:f2}");












    }
}