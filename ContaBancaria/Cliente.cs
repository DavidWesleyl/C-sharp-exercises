using System.Globalization;


namespace ContaBancaria
{
	internal class Cliente
	{


		public string Titular { get; set; } // Atributos

		public int Numero { get; private set; }

		public double Saldo { get; private set; }


		public Cliente() // Construtor Padrão recebe 0 
		{
			Saldo = 0;
		}

		public Cliente(string titular, int numero, double saldo ) // 1ª Sobrecarga onde recebe os dados do usuário que possui depósito inicial
		
		{

			Titular = titular;
			Numero = numero;
			Saldo = saldo;
		
		}

		public Cliente(string titular, int numero ) : this() // 2ª Sobrecarga onde o usuário não possui depósito inicial e por padão o saldo é 0, o THIS faz essa referência		
		{ 
			Titular = titular;
			Numero = numero;
			
		}

		public void Deposito(double saldo) // Método para depositar valores
		{
			Saldo += saldo;

		}

		public void Saque(double saldo) // Sacar valores e cobrar R$ 5.00 de taxa
		{
			Saldo -= saldo + 5.00;
		}



		public override string ToString()
		{
			return $"Titular: {Titular} | Conta: {Numero} | Saldo R$ {Saldo.ToString("f2", CultureInfo.InvariantCulture)} ";
		}




























	}









}

