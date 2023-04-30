internal class Program
{
    private static void Main(string[] args)
    {
        /* Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva 
        um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel 
        4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até 
        que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a 
        mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível */



        System.Console.WriteLine("      BEM VINDO    ");
        System.Console.WriteLine(" ");
        System.Console.WriteLine("1. Álcool");
        System.Console.WriteLine("2. Gasolina");
        System.Console.WriteLine("3. Diesel");
        System.Console.WriteLine("4. Sair");
        System.Console.WriteLine(" ");
        System.Console.Write("Por gentileza, digite o código: ");



        int opcao = int.Parse(Console.ReadLine());

        int Alcool = 0;
        int Gasolina = 0;
        int Diesel = 0;

        while (opcao != 4)
        {
            if (opcao == 1)
            {
                Alcool += 1;
                System.Console.WriteLine(" ");
                System.Console.WriteLine("Você tem preferencia por abastecer Álcool");
                System.Console.WriteLine($"{Alcool} Cliente(s) Abasteceram Álcool.");

            }

            else if (opcao == 2)
            {
                Gasolina += 1;
                System.Console.WriteLine(" ");
                System.Console.WriteLine("Você tem preferencia por abastecer Gasolina");
                System.Console.WriteLine($"{Gasolina} Cliente(s) Abasteceram Gasolina");

            }
            else if (opcao == 3)
            {
                Diesel += 1;
                System.Console.WriteLine(" ");
                System.Console.WriteLine("Você tem preferência por abastecer Diesel");
                System.Console.WriteLine($"{Diesel} Cliente(s) Abasteceram Diesel");

            }

            else if (opcao > 4)
            {
                System.Console.WriteLine(" ");
                System.Console.WriteLine("OPÇÃO INVÁLIDA!");
            }

            System.Console.WriteLine(" ");
            System.Console.Write("Por gentileza, digite o código: ");
            opcao = int.Parse(Console.ReadLine());


        }
        System.Console.WriteLine(" ");
        System.Console.WriteLine("MUITO OBRIGADO, TENHA UMA ÓTIMA SEMANA!");






    }
}