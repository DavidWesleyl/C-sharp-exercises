using Cadastro_de_Funcionario;
using System.Collections.Generic;
using System.Globalization;


internal class Program
{
	private static void Main(string[] args)
	{
        Console.Write("Quantos funcionários você irá cadastrar? ");
		int quantidade = int.Parse(Console.ReadLine());

		List<Funcionario> dados = new List<Funcionario>(); // Lista do tipo Class irá adicionar as informações passadas

		for(int inicio = 0; inicio < quantidade; inicio++)
		{
			Console.WriteLine();
            
			Console.WriteLine($"{inicio+1}º Funcionário");
			Console.Write("Digite o ID: ");
			int id = int.Parse(Console.ReadLine());


            Console.Write("Digite o nome: ");
			string nome = Console.ReadLine();


            Console.Write("Salário R$: ");
			double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			dados.Add(new Funcionario(id, nome, salario)); // Lista com as informações

        }

		Console.WriteLine();
		
		Console.Write("Digite o ID do funcionário que irá receber o aumento: ");
		int id_do_funcionario = int.Parse(Console.ReadLine());

		Funcionario pessoa_id = dados.Find(pessoa => pessoa.ID == id_do_funcionario);

		if (pessoa_id != null)
		{
            

            Console.Write("Quantos % de Aumento? ");
			int aumento_salarial = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
			pessoa_id.Aumento(aumento_salarial);
			
		}
		else
		{
            Console.WriteLine("ID do usuário não encontrado");
        }

        Console.WriteLine();
        Console.WriteLine("Lista Atualizada: ");
        
		foreach(Funcionario nomes in dados)
		{
			Console.WriteLine(nomes);
        }




















    }
}