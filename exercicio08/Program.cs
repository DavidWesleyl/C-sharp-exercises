internal class Program
{
    private static void Main(string[] args)
    {
        //Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.


        System.Console.WriteLine("** PAR OU IMPAR **");
        System.Console.WriteLine(" ");
        System.Console.Write("Digite um numero para saber se é par ou impar: ");

        int par_ou_impar = int.Parse(Console.ReadLine());

        if (par_ou_impar % 2 == 0)
        {
            Console.WriteLine($"O numero {par_ou_impar} é PAR!");
        }

        else

        {
            System.Console.WriteLine($"O número {par_ou_impar} é IMPAR!");

        }









    }
}