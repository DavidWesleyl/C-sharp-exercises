using System.Globalization;

namespace Cadastro_de_Funcionario
{
	internal class Funcionario
	{
        // Atributos da classe
        public int ID { get; set; } 
        public string Nome { get; set; }
        public double Salario { get; set; }

        // Construtor que irá receber as informções dos atributos

        public Funcionario(int id, string nome, double salario) 
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcentagem)
        {
            Salario += Salario * (porcentagem / 100.00);
        }

        // Método To String que vai retornar as informações

        public override string ToString()
        {
            return $"Nome: {Nome} | ID: {ID} | Salario R$: {Salario.ToString("f2", CultureInfo.InvariantCulture)}";
        }




    }
}
