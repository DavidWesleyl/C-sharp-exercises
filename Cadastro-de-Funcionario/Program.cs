using Cadastro_de_Funcionario;
using System.Collections.Generic;
using System.Globalization;


internal class Program
{
	private static void Main(string[] args)
	{
		/*	Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
			N funcionários. Não deve haver repetição de id.
			Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
			Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
			mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
			conforme exemplos.
			Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
			ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
			aumento por porcentagem dada */


		Console.Write("Quanto funcionários serão registrados? ");
		int quantidade = int.Parse(Console.ReadLine());

		List<Funcionarios> dados_funcionarios = new List<Funcionarios>();

		for (int inicio = 0; inicio < quantidade; inicio++)
		{
			Console.WriteLine();

			Console.WriteLine($"Funcionario #{inicio + 1}");

			Console.Write("Digite o ID: ");
			int id = int.Parse(Console.ReadLine());

			Console.Write("Digite o Nome: ");
			string nome = Console.ReadLine();

			Console.Write("Salario R$: ");
			double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			dados_funcionarios.Add(new Funcionarios(id, nome, salario));

		}

		Console.Write("Digite o ID do funcionário que irá receber o aumento: ");
		int id_do_funcionario = int.Parse(Console.ReadLine());

		Funcionarios id_escolhido = dados_funcionarios.Find(valor => valor.ID_Funcionario == id_do_funcionario);

		if (id_escolhido != null)
		{

			Console.Write("Digite a porcentagem do aumento: ");
			double aumento_do_funcionario = double.Parse(Console.ReadLine());

			id_escolhido.AumentoSalarial(aumento_do_funcionario);
		}
		else
		{
			Console.WriteLine("O ID Digitado não existe!");
		}

		Console.WriteLine("Lista Atualizada: ");

		foreach (Funcionarios cadastrados in dados_funcionarios)
		{
			Console.WriteLine(cadastrados);


		}



	}
}