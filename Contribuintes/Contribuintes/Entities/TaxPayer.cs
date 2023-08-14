using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
	internal abstract class TaxPayer // Classe abstrada onde irá servir de base para implementarmos nossas aplicações
	{
		public string Name { get; set; }
		public double AnualIncome { get; set; }




		public TaxPayer()
		{

		}

		public TaxPayer(string name, double anualincome)
		{
			Name = name;
			AnualIncome = anualincome;
		}

		public abstract double Tax(); // Como é uma classe abstrata, não retorna nada


	}
}
