using System;
namespace AlugueldeQuarto
{
	internal class Aluguel
	{
		public string Nome { get; set; } // Nome do usuário
		public string Email { get; private set; } // Email do usuário privado, sem risco de alterações



		public Aluguel() // Construtor padrão
		{
			
		}

		public Aluguel(string nome, string email) : this () // Sobrecarga01
		{
			Nome = nome;
			Email = email;
		}



		public override string ToString() // Método to String com as informações.
		{
			return $" Nome: {Nome} | Email: {Email}";
		}



	}
}
