using System;


namespace Terceirizado.Entities
{
	internal class Employee
	{
		public string Name { get; set; } // Encapsulamento | SubClasse

		public int Hours { get; set; }

		public double ValuePerHour { get; set; }


		public Employee()
		{

		}

		public Employee(string name, int hours, double valueperhour)
		{
			Name = name;
			Hours = hours;
			ValuePerHour = valueperhour;

		}

		// Virtual permite que o método seja sobrescrito na Subclasse que irá herdar esta SuperClasse.
		public virtual double Payment()
		{
			return ValuePerHour * Hours;
		}






	}
}
