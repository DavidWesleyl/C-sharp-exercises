internal class Program
{
    private static void Main(string[] args)
    {

        /* Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
           Lembrando que, por definição, fatorial de 0 é 1. */




        Console.Write("Digite um valor para ver o fatorial: ");
        int valores = int.Parse(Console.ReadLine());

        int fatorial = 1;



        for (int inicio = 1; inicio <= valores; inicio++)

        {
            fatorial = fatorial * inicio;





        }

        Console.WriteLine(" ");
        Console.WriteLine($">> O Fatorial de {valores} é {fatorial}!");











    }
}