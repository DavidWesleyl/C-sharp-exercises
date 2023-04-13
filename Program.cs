// input e output de variáveis //


using System;
using System.Globalization;

namespace DotNetCurso
{
    class Program
    {
        static void Main(string[] args)
        {
            string Produto1 = "Computador";
            string Produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5462;
            char genero = 'M';

            double Primeiro_Preco = 2100.0;
            double Segundo_Preco = 650.50;
            double Medida = 53.234567;


            System.Console.WriteLine($"{Produto1} cujo preço é R$ {Primeiro_Preco}");
            System.Console.WriteLine($"{Produto2} cujo preço é R$ {Segundo_Preco}");

            System.Console.WriteLine(" ");
            System.Console.WriteLine($"Registro: {idade} anos de idade, código do produto: {codigo}, Gênero {genero}");

            System.Console.WriteLine(" ");
            System.Console.WriteLine($"Medida com 8 casas decimais {Medida:f8}");
            System.Console.WriteLine($"Arredondado (3 casas decimais): {Medida:f3}");
            System.Console.WriteLine("Separador decimal invariant culture " + Medida.ToString("f3", CultureInfo.InvariantCulture));







        }


    }
}
