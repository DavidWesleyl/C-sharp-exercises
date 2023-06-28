internal class Program
{
	private static void Main(string[] args)
	{
		/* Fazer um programa para ler dois números inteiros M e N, e depois ler
		 uma matriz de M linhas por N colunas contendo números inteiros,
		 podendo haver repetições. Em seguida, ler um número inteiro X que
		 pertence à matriz. Para cada ocorrência de X, mostrar os valores à
		 esquerda, acima, à direita e abaixo de X.
		 */


		Console.Write("Digite a quantidade de Linhas: "); // Captura a quantidade de Linhas
		int linhas_da_matriz = int.Parse(Console.ReadLine());

		Console.Write("Digite a quantidade de Colunas: "); // Captura a quantidade de Colunas da Matriz
		int colunas_da_matriz = int.Parse(Console.ReadLine());

		int[,] MatrizPrincipal = new int[linhas_da_matriz, colunas_da_matriz]; // Cria a Matriz com as posições(linha e coluna)

		Console.WriteLine();
		for (int linhas = 0; linhas < linhas_da_matriz; linhas++) // => Laço para percorrer as linhas da Matriz
		{
			Console.Write($"Digite {colunas_da_matriz} valores da Matriz (mesma linha): "); // Aqui será criado um Vetor do tipo String, onde serão armazenados os valores em forma de Caractere => (" ")
			string[] ValoresdaMatriz = Console.ReadLine().Split();

			for (int colunas = 0; colunas < colunas_da_matriz; colunas++) // => lLaço para percorrer as Colunas da Matriz
			{
				MatrizPrincipal[linhas, colunas] = int.Parse(ValoresdaMatriz[colunas]); // Anteriormente criamos um vetor que armazenava os valores como String, aqui, ele será convertido em inteiro e integrado as posições da Matriz.
			}
		}

		Console.WriteLine();
		Console.Write("Qual valor digitado você deseja analisar?: ");
		int AnaliseValor = int.Parse(Console.ReadLine()); // Aqui será digitado o numero já digitado, onde será analisado.


		// --------  L a ç o   P a d r ã o  de  M a t r i z e s  --------------- // 

		for (int linha = 0; linha < linhas_da_matriz; linha++) // Linha
		{
			for (int coluna = 0; coluna < colunas_da_matriz; coluna++) // Coluna
			{
				if (MatrizPrincipal[linha, coluna] == AnaliseValor) // Aqui, SE a Matriz na posição linha e coluna desse laço, for igual ao valor de Análise:
				{
					Console.WriteLine();
					Console.WriteLine($"Posição: [{linha},{coluna}]"); // Mostre a Posição em que ele se encontra


					Console.WriteLine($"Cima: {MatrizPrincipal[linha - 1, coluna]}"); // O valor acima dele

					Console.WriteLine($"Baixo: {MatrizPrincipal[linha + 1, coluna]}"); // O valor abaixo

					Console.WriteLine($"Esquerda: {MatrizPrincipal[linha, coluna - 1]}"); // O valor a esquerda

					Console.WriteLine($"Direita: {MatrizPrincipal[linha, coluna + 1]}"); // O valor a direita.
				}

			}
		}








	}
}
