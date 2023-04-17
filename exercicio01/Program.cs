internal class Program
{
    private static void Main(string[] args)
    {
        // FAÇA UM PROGRAMA QUE LEIA DOIS NUMEROS INTEIROS E MOSTRE A SOMA 

        Console.Write("Digite o primeiro número: ");

        int numero1 = int.Parse(Console.ReadLine());

        System.Console.Write("Digite o segundo numero: ");

        int numero2 = int.Parse(Console.ReadLine());


        int soma = numero1 + numero2;

        System.Console.WriteLine($"A soma dos valores digitados, é: {soma}");
    }
}