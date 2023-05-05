internal class Program
{
    private static void Main(string[] args)
    {
        // Ler um número inteiro N e calcular todos os seus divisores.



        Console.Write("Digite um numero para saber os divisores: ");
        int numero = int.Parse(Console.ReadLine());

        for (int inicio = 1; inicio <= numero; inicio++)
        {
            if (numero % inicio == 0) // Para saber os divisores de um numero, o resto da divisão precisa ser um valor inteiro, reto zero.
            {
                Console.WriteLine(inicio);
            }
           
        }




        












    }
}