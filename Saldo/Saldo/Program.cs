using Saldo.Entities;
using Saldo.Entities.Exceptions;
using System.Globalization;
internal class Program
{
	private static void Main(string[] args)
	{
		/* Fazer um programa para ler os dados de uma conta bancária e depois realizar um saque nesta conta bancária, mostrando o novo saldo.
         Um saque não pode ocorrer ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de saque da conta  */


		try // tente executar: 
		{
			Console.WriteLine("Enter account data ");
			Console.WriteLine();

			Console.Write("Number: ");
			int account_number = int.Parse(Console.ReadLine());

			Console.Write("Holder: ");
			string holder_name = Console.ReadLine();

			Console.Write("Balance $: ");
			double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.Write("Withdraw limit $:");
			double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine();


			Console.Write("Enter amount for Withdraw: ");
			double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Account client_account = new Account(account_number, holder_name, balance, limit);

			client_account.Withdraw(amount);

			Console.WriteLine();

			Console.WriteLine(client_account);
		}
		// Caso dê erro, trataremos: 

		catch (DomainException exception) 
		{
            Console.WriteLine();
            Console.WriteLine(exception.Message);

        }

		// Caso seja um formato inválido, trataremos: 
		catch (FormatException exception) 
		{
            Console.WriteLine();
            Console.WriteLine($"Format error! {exception.Message} Try again. ");
        }



















	}
}