using System;
using System.Globalization;
internal class Program
{
    private static void Main()
    {
        System.Console.Write("Entre com o seu nome completo: "); // Nome

        string nome = Console.ReadLine();


        System.Console.Write("Quantos cômodos tem na susa casa?: "); // Comodos

        int comodos = int.Parse(Console.ReadLine());


        System.Console.Write("Entre com o preço de um produto: "); // Preço do produto

        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        // Output
        System.Console.WriteLine(" ");
        System.Console.WriteLine($"Seu nome é {nome}");
        System.Console.WriteLine($"Sua casa tem {comodos} comodos.");
        System.Console.WriteLine($"Preço digitado: {preco.ToString(CultureInfo.InvariantCulture)}");

        System.Console.WriteLine("------------------------------------------------------------------------------------------------------");



        System.Console.WriteLine("Entre com seu ultimo nome, idade e altura (Mesma linha)"); // Todas as informações armazenadas em um vetor

        string[] informacoes = Console.ReadLine().Split(' '); // -> Irá ler as informações de variáveis diferentes na mesma linha 

        string Nome_do_usuario = informacoes[0];
        int idade_do_usuario = int.Parse(informacoes[1]);
        double altura_do_usuario = double.Parse(informacoes[2], CultureInfo.InvariantCulture);


        System.Console.WriteLine(" ");
        System.Console.WriteLine(Nome_do_usuario);
        System.Console.WriteLine(idade_do_usuario);
        System.Console.WriteLine(altura_do_usuario.ToString(CultureInfo.InvariantCulture));



    }

}
