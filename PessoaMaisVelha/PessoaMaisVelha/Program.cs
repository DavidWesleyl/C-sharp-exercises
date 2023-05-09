using PessoaMaisVelha;
using System;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        // Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha

        /*  Esse exercicio foi o início dos estudos de POO,
            feito com a Criação de Classes, nesse caso uma classe chamada "Cadastro" onde terá dois atributos. 
            um Atributo -> Public String Nome; e outro Public int Idade. <- onde serão armazenados os valores.  */


        Cadastro PrimeiraPessoa, SegundaPessoa; // <- Chamada da Classe e variáveis que serão usadas.

        PrimeiraPessoa = new Cadastro(); // <- "New Cadastro()" é a instanciação dos valores, sendo atribuidas as variáveis.
        SegundaPessoa = new Cadastro(); // Obrigatório no  uso de Classes.

        Console.WriteLine(" DADOS DA PRIMEIRA PESSOA ");
        Console.WriteLine("----------------------------------");

        Console.Write("Digite o nome da Primeira Pessoa: ");
        PrimeiraPessoa.Nome = Console.ReadLine(); // Variável primeira pessoa, atribuida a Nome.

        
        
        Console.Write("Digite a idade: ");
        PrimeiraPessoa.Idade = int.Parse(Console.ReadLine()); // Variável primeira pessoa atribuida a Idade.

        
        
        Console.WriteLine(" ");

        Console.WriteLine(" DADOS DA SEGUNDA PESSOA ");
        Console.WriteLine("----------------------------------");

        Console.Write("Digite o nome da Segunda Pessoa: ");
        SegundaPessoa.Nome = Console.ReadLine(); // Variável segunda pessoa atribuida a Nome.

        
        Console.Write("Digite a idade: ");
        SegundaPessoa.Idade = int.Parse(Console.ReadLine()); // Variável segunda pessoa atribuida a Idade.

        
        Console.WriteLine("");


        if (PrimeiraPessoa.Idade > SegundaPessoa.Idade)
        
        {
            Console.WriteLine($"O mais velho(a) é {PrimeiraPessoa.Nome}, com {PrimeiraPessoa.Idade} anos.");

        }

        else
        
        {
            Console.WriteLine($"O mais velho(a) é {SegundaPessoa.Nome}, com {SegundaPessoa.Idade} anos.");

        }







    }
}