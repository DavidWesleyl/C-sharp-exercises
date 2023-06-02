using AlugueldeQuarto;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

internal class Program
{
	private static void Main(string[] args)
	{
		/*	A dona de um pensionato possui dez quartos para alugar para estudantes,
			sendo esses quartos identificados pelos números 0 a 9.
			Quando um estudante deseja alugar um quarto, deve-se registrar o nome
			e email deste estudante.
			Fazer um programa que inicie com todos os dez quartos vazios, e depois
			leia uma quantidade N representando o número de estudantes que vão
			alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
			N estudantes. Para cada registro de aluguel, informar o nome e email do
			estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
			que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
			um relatório de todas ocupações do pensionato, por ordem de quarto*/




		Console.Write("Quantos quartos serão alugados? "); 

		int quantidade_de_quartos = int.Parse(Console.ReadLine()); // Entrada de quartos a ser alugados 

		Aluguel[] vect = new Aluguel[10]; // vetor indicando que só há 10 quartos 

        Console.WriteLine();

        for (int inicio = 0;  inicio < quantidade_de_quartos; inicio++) // Laço FOR com inicio zero; se o inicio for menor que a quantidade informada; implemente + 1.
		{
            Console.WriteLine($"Aluguel #{inicio+1}");
            
			Console.Write("Nome: ");
			string nome = Console.ReadLine(); // Captura de nome do usuário

       

            Console.Write("Email: ");
			string email = Console.ReadLine(); // Captura do email

         

            Console.Write("Numero do Quarto:");
			int quarto = int.Parse(Console.ReadLine()); // Captura do numero do quarto

        

            vect[quarto] = new Aluguel(nome, email); // Vetor criado na posição da numeração do quarto, onde irão ser armazenadas as informações dos inquilinos de acordo com o quarto

			Console.WriteLine();

        }

        Console.WriteLine();
        Console.WriteLine("Quartos ocupados: ");

		for (int inicio = 0; inicio < 10; inicio++) // Laço de repetição FOR; inicio zero; enquanto o inicio for menor que 10 (quantidade de quartos) implemete + 1
		{
            
            if (vect[inicio] != null) // Se o vetor na posição inicio for diferene de nulo
			{
				Console.WriteLine();
                Console.WriteLine($"{inicio} : {vect[inicio]}"); // Mostre o numero do quarto e as informações em ordem
            }
		}
































	}
}