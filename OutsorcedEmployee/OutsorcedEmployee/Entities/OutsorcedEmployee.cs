using System;

namespace Terceirizado.Entities
{
	internal class OutsorcedEmployee : Employee	
	{
		public double AdditionalCharge { get; set; } // SubClasse que Herdou a SuperClasse, seus métodos e atributos.


		public OutsorcedEmployee()
		{

		}

		public OutsorcedEmployee(string name, int hours, double valueperhour, double additionalcharge)
			: base(name, hours, valueperhour)
		{
			AdditionalCharge = additionalcharge;
		}

		public override double Payment() // Método Payment da Superclasse, sobrescrito e modificado
		{
			return base.Payment() + 1.1 * AdditionalCharge;
		}





	}
}
