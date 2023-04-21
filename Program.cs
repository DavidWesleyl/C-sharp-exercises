internal class Program
{
    private static void Main(string[] args)
    {
        // Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.

        System.Console.Write("Digite um número para saber se ele é negativo ou não: ");

        int numero = int.Parse(Console.ReadLine());


        if (numero < 0)
        {
            System.Console.WriteLine($"O número {numero} é negativo");
        }

        else
        {
            System.Console.WriteLine($"O numero {numero} é Positivo! ");

        }









    }
}