using System;
using Reservation.Entities.Exceptions;

namespace Reservation.Entities
{
	internal class Reservations
	{
		public int RoomNumber { get; set; }
		public DateTime Checkin { get; set; }
		public DateTime Checkout { get; set; }


		public Reservations() { }




		public Reservations(int roomnumber, DateTime checkin, DateTime checkout)
		{
			if (checkout <= checkin)
			{
				throw new DomainExceptions("Error! Check-out must be after check- in");

			}

			RoomNumber = roomnumber;
			Checkin = checkin;
			Checkout = checkout;
		}

		public int Duration()
		{
			TimeSpan duration = Checkout - Checkin;
			int vacation = duration.Days;
			return vacation;

		}

		public void Update(DateTime checkin, DateTime checkout)
		{
			DateTime now = DateTime.Now;

			if (checkin < now || checkout < now)
			{
				throw new DomainExceptions("for update dates need to be in the future.");
			}

			else if (checkout <= checkin)
			{
				throw new DomainExceptions("Error! Check-out must be after check- in");


			}

			Checkin = checkin;
			Checkout = checkout;
		}

		public override string ToString()
		{
			return $"Room number: {RoomNumber} | Check-in: {Checkin.ToString("dd/MM/yyyy")} | Check-out: {Checkout.ToString("dd/MM/yyyy")} | Quantity days: {Duration()}";
		}
	}
}
