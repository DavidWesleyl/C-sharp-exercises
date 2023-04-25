using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        /* Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem 
        que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem 
        qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
        Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e 
        mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo*
        
        -----------------------------
        De 0 a 2.000 - Isento
        De 2000.01 a 3.000 - 8% 
        De 3.000.01 a 4500.00 - 18%
        Acima de 4500.00 - 28% 
        ------------------------------

        
              
        */


        System.Console.WriteLine("IMPOSTO DE RENDA");
        System.Console.Write("Digite o valor: ");

        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double imposto;

        if (salario <= 2000.0)
        {
            imposto = 0.0;
            System.Console.WriteLine("Seu imposto é Isento");

        }
        else if (salario == 2000.01 || salario <= 3000)
        {
            imposto = salario * 0.08;
            System.Console.WriteLine($"Total a pagar: 8% do valor: R$ {imposto:f2}");
        }

        else if (salario == 3000.01 || salario <= 4500)
        {
            imposto = salario * 0.18;
            System.Console.WriteLine($"Total de imposto a pagar: 18% do valor: R$ {imposto:f2}");

        }

        else if (salario > 4500)
        {
            imposto = salario * 0.28;
            System.Console.WriteLine($"Total de imposto a pagar: 28% do valor: R$ {imposto:f2}");

        }


















    }
}