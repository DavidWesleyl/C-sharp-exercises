using System.Numerics;
using System.Runtime.Serialization.Formatters;

internal class Program
{
	private static void Main(string[] args)
	{
		/* Fazer um programa para ler um número inteiro N e uma matriz de
		ordem N contendo números inteiros. Em seguida, mostrar a diagonal
		principal e a quantidade de valores negativos da matriz. */


		Console.Write("Digite as dimensões da Matriz (Linhas e colunas): "); // Vai Capturar a entrada das dimensões da matriz (Linha e Coluna).
		int dimensao = int.Parse(Console.ReadLine());


		int[,] Matriz = new int[dimensao, dimensao]; // Declaração de Matriz, no caso a quantidade de linhas será igual a de colunas.

		int negativos = 0; // Variável chamada negativos valendo 0, por enquanto.


		// Para percorrer uma Matriz, a estrutura base são dois laços FOR, um dentro do outro. Nesse caso foi criado um para percorrer linhas e outro, colunas.

		for (int linhas = 0; linhas < dimensao; linhas++) // => Laço de Linhas
		{
			Console.Write("Digite os valores (mesma linha): "); // Entrada dos valores da Matriz na mesma linha.

			string[] Valores = Console.ReadLine().Split(); // Aqui foi criado um vetor do tipo string onde receberá os valores passados, que posteriormente será convertido em inteiro. 

			for (int colunas = 0; colunas < dimensao; colunas++) // => Laço de Colunas
			{
				Matriz[colunas, linhas] = int.Parse(Valores[colunas]); // Aqui será a conversão do vetor. Onde -- Matriz na posição linha e coluna, irá receber uma conversão inteira de Valores(vetor) em pos colunas.


				if (Matriz[colunas, linhas] < 0) // Dentro do mesmo laço, irá verificar se após percorrer os valores, houver um valor menor que zero
				{
					negativos++; // A Var negativo (0, irá somar os valores menores que zero.)
				}

			}


		}

		Console.WriteLine();

		Console.WriteLine("Diagonal principal: ");

		for (int diagonal = 0; diagonal < dimensao; diagonal++) // Esse laço irá mostrar a diagonal da Matriz
		{

			Console.Write($" {Matriz[diagonal, diagonal]} ");
		}

		Console.WriteLine();

		Console.WriteLine($"Numeros negativos: {negativos}"); // Esse laço irá mostrar os valores negativos


















	}
}