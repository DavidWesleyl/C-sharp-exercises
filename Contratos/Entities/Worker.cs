﻿using Contratos.Entities.Enum;
using System;
using System.Collections.Concurrent;


namespace Contratos.Entities
{
	internal class Worker
	{
		public string Name { get; set; }
		public WorkerLevel Level { get; set; }
		public double BaseSalary { get; set; }
		public Departments Department { get; set; }
		public List<HourContract> Contracts { get; set; } = new List<HourContract>();

		public Worker()
		{

		}

		public Worker(string name, WorkerLevel level, double baseSalary, Departments department)
		{
			Name = name;
			Level = level;
			BaseSalary = baseSalary;
			Department = department;
		}

		public void AddContract(HourContract contract)
		{
			Contracts.Add(contract);

		}

		public void RemoveContract(HourContract contract)
		{
			Contracts.Remove(contract);
		}

		public double Income(int year, int month)
		{
			double soma = BaseSalary;

			foreach (HourContract contract in Contracts)
			{
				if (contract.Date.Year == year && contract.Date.Month == month)
				{
					soma += contract.TotalValue();

				}

			}
			return soma;


		}

	}
}
