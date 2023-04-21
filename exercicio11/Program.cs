internal class Program
{
    private static void Main(string[] args)
    {

        /*Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
        seguir, calcule e mostre o valor da conta a pagar. 


        Codigo | P r o d u t o  | P r e ç o 
        -------------------------------------
          1 -  Cachorro Quente   R$ 4.00
          2 -  X-Salada          R$ 4.50
          3 -  X-Bacon           R$ 5.00
          4 -  Torrada Simples   R$ 2.00
          5 -  Refrigerante      R$ 1.00                                            */



        System.Console.Write("Digite o código e ao lado a quantidade do produto: ");

        string[] cardapio = Console.ReadLine().Split(' ');
        System.Console.WriteLine(" ");

        int codigo = int.Parse(cardapio[0]);
        double quantidade = double.Parse(cardapio[1]);

        double total;

        if (codigo == 1)
        {
            total = quantidade * 4;
            System.Console.WriteLine($"O total do Cachorro quente será: R$ {total:f2}");
        }


        else if (codigo == 2)
        {
            total = quantidade * 4.50;
            System.Console.WriteLine($"O total do X-Salada será: R$ {total:f2}");
        }


        else if (codigo == 3)
        {

            total = quantidade * 5;
            System.Console.WriteLine($"O total do X-Bacon será: R$ {total:f2} ");

        }


        else if (codigo == 4)
        {

            total = quantidade * 2.00;
            System.Console.WriteLine($"O total da Torrada Simples será R$ {total:f2}");

        }


        else if (codigo == 5)
        {

            total = quantidade * 1;
            System.Console.WriteLine($"O total do Refrigerante será R$ {total:f2}");

        }











    }



}