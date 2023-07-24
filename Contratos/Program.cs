using Contratos.Entities;
using Contratos.Entities.Enum;
using System.Globalization;

internal class Program
{
	private static void Main(string[] args)
	{
		/*Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar 
		do usuário um mês e mostrar qual foi o salário do funcionário nesse mês*/


		Console.Write("Enter with department's name: "); // Nome do Departamento
		string Department_Name = Console.ReadLine();

		Console.WriteLine();

		Console.WriteLine("----- Enter Worker Data -----");

        Console.WriteLine();

        Console.Write("Name: "); // Nome do Usuário
		string Name = Console.ReadLine();

		Console.Write("Level (Junior/MidLevel/Senior): "); // Nível do Usuário
		WorkerLevel Level = Enum.Parse<WorkerLevel>(Console.ReadLine());

		Console.Write("Base Salary: ");
		double Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Salário Base do usuário

		Departments Departamento = new Departments(Department_Name); // Instancia de Departaments
		Worker Dados = new Worker(Name, Level, Salary, Departamento); // Instancia de Worker

		Console.WriteLine();

		Console.Write("How many contracts to this worker? "); //Quantidade de Contratos
		int quantidade = int.Parse(Console.ReadLine());

		for (int inicio = 1; inicio <= quantidade; inicio++)
		{
			Console.WriteLine($"Enter with the #{inicio} contract: ");

			Console.Write("Date (dd/mm/yyy): ");
			DateTime Data = DateTime.Parse(Console.ReadLine()); // Data (Dia/Mês/Ano)

			Console.Write("Value Per Hour: ");
			double Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Valor recebido por hora

			Console.Write("Duration (Hours): ");
			int Duracao = int.Parse(Console.ReadLine()); // Quantidade de Horas

			Console.WriteLine();

			HourContract contratos = new HourContract(Data, Valor, Duracao); // Instancia dos contratos

			Dados.Contracts.Add(contratos); // Adição dos contratos no Método

		}

		Console.WriteLine();

		Console.Write("Enter With Month and Year to Calculate Income (Only (MM/YYYY)): "); // Análise APENAS do Mês e Ano (MM/yyyy)

		string Month_and_Year = Console.ReadLine(); // Variável string para posteriormente tratá-la com o método substring

		int Month = int.Parse(Month_and_Year.Substring(0, 2)); // Vai pegar a string digitada á partir da posição 0 à 2, passando de string para inteiro
		int Year = int.Parse(Month_and_Year.Substring(3)); // Vai pegar a string digitada á partir da posição 3, passando de string para inteiro


		// Dados Mostrados

		Console.WriteLine();
		Console.WriteLine($"Name: {Dados.Name}");
		Console.WriteLine($"Department: {Dados.Department.Name}");
		Console.WriteLine($"Income for {Month_and_Year}: {Dados.Income(Year, Month).ToString("f2", CultureInfo.InvariantCulture)}");




















	}
}