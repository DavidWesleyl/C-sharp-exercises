using System;
using System.Globalization;


namespace DadosdoFuncionario
{
    internal class Funcionario
    {

        public string Nome;
        public double Salario;
        public double Imposto;




        public double SalarioLiquido()
        {
            return Salario - Imposto;



        }


        public override string ToString()
        {
            return $"Funcionário: {Nome} | R$: {(SalarioLiquido()).ToString("f2", CultureInfo.InvariantCulture)}";
        }

        public void Aumento(double aumento)
        {
            Salario = Salario + (Salario * aumento / 100.0);

            
        }











    }
}
