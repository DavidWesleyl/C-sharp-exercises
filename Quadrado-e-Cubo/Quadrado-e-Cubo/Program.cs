internal class Program
{
    private static void Main(string[] args)
    {
        /* Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas, 
        começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor */


        Console.Write("Digite um valor: ");
        int valor = int.Parse(Console.ReadLine());
        int quadrado = 0;
        int cubo = 0;

        Console.WriteLine(" ");
        Console.WriteLine(" Coluna | Quadrado | Cubo ");
        for (int inicio = 1; inicio <= valor; inicio++)
        
        {
            
            quadrado = inicio * inicio;
            cubo = quadrado * inicio;

            Console.WriteLine(" ");
            Console.WriteLine($" {inicio}  {quadrado}  {cubo}  ");


        }

        
            











    }
}