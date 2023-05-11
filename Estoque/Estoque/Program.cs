using Estoque;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        /* Faça um program que leia os dados de um produto em estoque (Nome, Preço e quantidade em estoque). Em seguida: 
          
        -> Mostre os dados do Produto ( Nome, preço, quantidade e quantidade total)
        -> Realize uma entrada no Estoque e mostre novamente4 os resultados 
        -> Realize uma saída no estoque e mostre novamente os produtos */
        // OBS: Nesse Projeto foi criada uma Classe chamada "Produtos", com 3 atributos e 3 Métodos.
                                                                                                                    
        
        Produto itens;

        itens = new Produto();

        Console.WriteLine("    D A D O S  D O  P R O D U T O    ");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine(" ");

        Console.Write("Produto: ");
        itens.Nome = Console.ReadLine();


        Console.Write("Valor R$: ");
        itens.Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


        Console.Write("Quantidade: ");
        itens.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine(" ");


        Console.WriteLine($"Relação: {itens}");

        Console.WriteLine(" ");
        
        Console.Write("Digite a quantidade de produtos a ser adicionada no estoque: ");
        int Adicao_de_Produtos = int.Parse(Console.ReadLine());
        itens.AdicionarProdutos(Adicao_de_Produtos);

        Console.WriteLine(" ");
        Console.WriteLine($"Relação Atualizada >> {itens}");

        
        Console.WriteLine(" ");
        
        Console.Write("Digite a Quantidade de Produtos a ser removida do estoque: ");
        int RemocaodeProdutos = int.Parse(Console.ReadLine());
        itens.RemoverProdutos(RemocaodeProdutos);

        
        Console.WriteLine(" ");
        Console.WriteLine($"Relação Atualizada >> {itens}");
























    }
}
