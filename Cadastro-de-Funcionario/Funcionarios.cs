using System;
using System.Globalization;

namespace Cadastro_de_Funcionario
{
	internal class Funcionarios
	{
		// Atributos

		public int ID_Funcionario { get; private set; }
		public string Nome_Funcionario { get; set; }
		public double Salario_Funcionario { get; private set; }


		public Funcionarios(int id, string nome, double salario)
		{
			ID_Funcionario = id;
			Nome_Funcionario = nome;
			Salario_Funcionario = salario;
		}

		public void AumentoSalarial(double porcentagem)
		{
			Salario_Funcionario += Salario_Funcionario * (porcentagem / 100.00);
		}

		public override string ToString()
		{
			return $"ID: {ID_Funcionario} | Nome: {Nome_Funcionario} | Salario R$: {Salario_Funcionario.ToString("f2", CultureInfo.InvariantCulture)}";
		}










	}
}
