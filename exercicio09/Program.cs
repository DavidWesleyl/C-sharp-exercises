internal class Program
{
    private static void Main(string[] args)
    {
        /*  Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
            Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
            ordem crescente ou decrescente. */



        System.Console.WriteLine("** NUMEROS MULTIPLOS **");
        System.Console.WriteLine(" ");
        System.Console.Write("Digite os numeros para ver se são multiplos: ");

        string[] num = Console.ReadLine().Split(' '); // Digitados na mesma linha

        double num_1 = double.Parse(num[0]);
        double num_2 = double.Parse(num[1]);

        /* Para saber se os numeros são multiplos, devemos dividi-los, re o resultado for um número inteiro, é multiplo
        caso contrário, não será. */



        if (num_1 / num_2 % 2 == 0 || num_2 / num_1 % 2 == 0)
        {
            System.Console.WriteLine("Os numeros digitados SÃO multiplos! ");
        }
        else
        {
            System.Console.WriteLine("Os numeros digitados NÃO são multiplos");

        }




    }
}