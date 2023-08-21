using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saldo.Entities.Exceptions
{
	// Essa é uma exceção personalizada que criamos, para usarmos em nosso sistema. Ela herda da super classe "Application Exception".
	internal class DomainException : ApplicationException 
	{
		public DomainException(string message) 
			: base(message)
		{
			
		}
	}
}
