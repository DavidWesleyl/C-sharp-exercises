
using System.Globalization;
using TrimestreAluno;

internal class Program
{
    private static void Main(string[] args)
    {
        /*  Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano 
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no 
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam 
            para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver 
            este problema */

        
        /* Neste exercicio foi Criada uma classe chamada "Aluno", onde a mesma recebe 3 Atributos para armazenar as notas.
           Também foi criado 3 métodos, no qual 1. Calcula o valor das notas, 2.Retorna se está ou não Aprovado, 3. Mostra quantos pontos faltaram para aprovação.*/

        
        
        Aluno notas = new Aluno();

        Console.Write("Digite o nome do Aluno: ");
        notas.Nome = Console.ReadLine();
        
        Console.WriteLine("Abaixo, digite as 3 notas do Aluno: ");
        notas.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        notas.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        notas.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.WriteLine($"Nota FinaL = {notas.NotaFinal().ToString("f2", CultureInfo.InvariantCulture)}");
        Console.WriteLine();

        if (notas.Aprovado())
        
        {
            Console.WriteLine("Aprovado");
        }
        
        
        else
        {
            
            Console.WriteLine("Reprovado"); ;
            Console.WriteLine($"Faltaram {notas.NotasRestantes().ToString("f2", CultureInfo.InvariantCulture)} pontos.");


        }








    }
}