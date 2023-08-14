using System;

namespace Contribuintes.Entities
{
	internal class Company : TaxPayer
	{
		public int NumberOfEmployees { get; set; }

		public Company()
		{
		}

		public Company(string name, double anualincome, int numberOfEmployees)
			: base(name, anualincome)
		{
			NumberOfEmployees = numberOfEmployees;
		}

		public override double Tax()
		{
			double total = 0.0;

			if (NumberOfEmployees < 10)
			{
				total = AnualIncome * 0.16;

			}

			else
			{
				total = AnualIncome * 0.14;

			}

			return total;





		}


	}
}
