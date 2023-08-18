using Reservation.Entities;
using Reservation.Entities.Exceptions;

internal class Program
{
	private static void Main(string[] args)
	{
		/* Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
		   de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
	       dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
		   novamente a reserva com os dados atualizados. O programa não deve aceitar dados
		   inválidos para a reserva, conforme as seguintes regras:
		  - Alterações de reserva só podem ocorrer para datas futuras
		  - A data de saída deve ser maior que a data de entrada */

		try
		{
			Console.Write("Room number: ");
			int room_number = int.Parse(Console.ReadLine());

			Console.Write("Check-in: ");
			DateTime checkin = DateTime.Parse(Console.ReadLine());

			Console.Write("Check-out: ");
			DateTime checkout = DateTime.Parse(Console.ReadLine());

			Console.WriteLine();



			Reservations reservation = new Reservations(room_number, checkin, checkout);
			Console.WriteLine(reservation);

			Console.WriteLine();

			Console.WriteLine("Enter data to update Reservation: ");

			Console.Write("Check-in: ");
			checkin = DateTime.Parse(Console.ReadLine());

			Console.Write("Check-out: ");
			checkout = DateTime.Parse(Console.ReadLine());

			DateTime now = DateTime.Now;



			reservation.Update(checkin, checkout);

			Console.WriteLine();

			Console.WriteLine(reservation);
		}


		catch (DomainExceptions exceptions_created)
		{
			Console.WriteLine();

			Console.WriteLine($"Something wrong {exceptions_created.Message}");
		}

		catch (FormatException exception)
		{
			Console.WriteLine($"Unexpected Error! {exception.Message}");
		}











	}




}
