using DadosdoFuncionario;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        /*  Fazer um programa para ler os dados de um funcionário (nome, 
            salário bruto e imposto). Em seguida, mostrar os dados do 
            funcionário (nome e salário líquido). Em seguida, aumentar o salário 
            do funcionário com base em uma porcentagem dada (somente o 
            salário bruto é afetado pela porcentagem) e mostrar novamente os 
            dados do funcionário. Use a classe projetada abaixo  */





        Funcionario dados;

        dados = new Funcionario();

        Console.WriteLine("     D A D O S   D O   F U N C I O N Á R I O     ");
        Console.WriteLine();

        Console.Write("Nome: ");
        dados.Nome = Console.ReadLine();

        Console.Write("Salário Bruto: ");
        dados.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.Write("Imposto: ");
        dados.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine();
        Console.Write(dados);

        Console.WriteLine();
        Console.Write("Digite a pocentagem para aumentar o salário: ");
        int Aumento = int.Parse(Console.ReadLine());

        dados.Aumento(Aumento);

        


        Console.WriteLine();
        Console.WriteLine($"Dados Atualizados >>: {dados} ");






















    }
}