using System;


namespace Reservation.Entities.Exceptions
{
	internal class DomainExceptions : ApplicationException
	{
		public DomainExceptions(string name)
			: base(name)
		{

		}
	}
}
