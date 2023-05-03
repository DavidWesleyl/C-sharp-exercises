internal class Program
{
    private static void Main(string[] args)
    {

        /* Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
        X, se for o caso. */


        Console.Write("Digite um valor para ver a contagem em impar: ");
        int valores = int.Parse(Console.ReadLine());



        for (int numero = 1; numero <= valores; numero++) 
        {
            if (numero % 2 != 0)
            {
                Console.WriteLine(numero);

            }
            






        }



























    }
}