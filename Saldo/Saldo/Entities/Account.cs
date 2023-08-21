using Saldo.Entities.Exceptions;
using System;
using System.Globalization;

namespace Saldo.Entities
{
	internal class Account
	{
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account() { }

        public Account(int number, string holder, double balance, double withdrawbalance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawbalance;
        }

        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit) // Aqui usaremos nossa exceção criada, caso: A quantia seja maior que o limite de saque
            {
                throw new DomainException("Withdraw error! The amount exceeds whitdraw limits "); // lançe uma nova "DomainException"
            }
            if(amount < Balance) // Aqui usaremos nossa exceção criada, caso: A quantia seja menor que o Saldo
			{
                throw new DomainException("Error! Not enought balance"); // lance uma nova "DomainException"
            }

            Balance = Balance - amount;
        }

		public override string ToString()
		{
			return $"New Balance $: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
		}




	}
}
