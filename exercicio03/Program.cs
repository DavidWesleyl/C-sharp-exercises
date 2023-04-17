internal class Program
{
    private static void Main(string[] args)
    {
        /* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto 
        de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D) */

        System.Console.Write(" >> Digite o primeiro número: ");

        int numero_01 = int.Parse(Console.ReadLine());

        System.Console.Write(" >> Digite o segun número: ");

        int numero_02 = int.Parse(Console.ReadLine());

        System.Console.Write(" >> Digite o terceiro número: ");

        int numero03 = int.Parse(Console.ReadLine());

        System.Console.Write(" >> Digite o quarto número: ");

        int numero_04 = int.Parse(Console.ReadLine());


        int calculo = (numero_01 * numero_02) - (numero03 * numero_04);

        System.Console.WriteLine(" ");

        System.Console.WriteLine($"A diferença dos valores, terá como resultado: {calculo}");













    }
}