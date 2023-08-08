using System.Globalization;
using System.Xml.Linq;
using Terceirizado.Entities;

internal class Program
{
	// Mini Aplicação console construida com os pilares da Orientação a Objetos: Encapsulamento, Herança e Polimorfismo
	private static void Main(string[] args)
	{
		List<Employee> employee_list = new List<Employee>();


		Console.Write("Enter the numer of employees: ");
		int quantity = int.Parse(Console.ReadLine());

		Console.WriteLine();

		for (int inicio = 1; inicio <= quantity; inicio++)
		{
			Console.WriteLine($"Employee #{inicio} data: ");
			Console.WriteLine();

			Console.Write("Outsorced? (y/n): ");
			string outsorced = Console.ReadLine();

			Console.WriteLine();

			if (outsorced == "n")
			{

				Console.Write("Name: ");
				string name = Console.ReadLine();

				Console.Write("Hours: ");
				int hours = int.Parse(Console.ReadLine());

				Console.Write("Value Per Hour: ");
				double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				employee_list.Add(new Employee(name, hours, valueperhour)); // Polimorfismo

				Console.WriteLine();


			}
			else
			{
				Console.WriteLine();

				Console.Write("Name: ");
				string name = Console.ReadLine();

				Console.Write("Hours: ");
				int hours = int.Parse(Console.ReadLine());

				Console.Write("Value Per Hour: ");
				double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				Console.Write("Additional charge: ");
				double additionalcharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

				employee_list.Add(new OutsorcedEmployee(name, hours, valueperhour, additionalcharge)); // Polimorfismo / Aqui usamos o mesmo tipo para fins diferentes

				Console.WriteLine();


			}


		}

		Console.WriteLine("P A Y M E N T S");
		Console.WriteLine();


		foreach (Employee employee_data in employee_list)
		{
			Console.WriteLine($"Name: {employee_data.Name} / Salary: {employee_data.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
		}



	}
}