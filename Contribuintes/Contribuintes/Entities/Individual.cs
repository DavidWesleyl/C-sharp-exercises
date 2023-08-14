using System;
using System.Globalization;

namespace Contribuintes.Entities
{
	internal class Individual : TaxPayer // Essa subclasse herda da Super classe abstrata
	{
		public double HealthExpenditures { get; set; }

		public Individual()
		{

		}

		public Individual(string name, double anualincome, double healthExpenditures)
			: base(name, anualincome)
		{
			HealthExpenditures = healthExpenditures;
		}

		public override double Tax()
		{
			double total = 0.0;



			if (AnualIncome >= 20000.00)
			{
				total = (AnualIncome * 0.25) - HealthExpenditures * 0.5;
			}

            else
            {
				total = (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }

            return total;


		}
	}
}
