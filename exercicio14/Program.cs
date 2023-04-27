internal class Program
{
    private static void Main(string[] args)
    {
        // LEIA 3 NUMEROS INTEIROS E DIGA QUAL O MAIOR // 

        System.Console.WriteLine("LENDO MAIOR VALOR");
        System.Console.WriteLine("Digite 3 valores para ver qual o maior: ");
        System.Console.WriteLine(" ");

        int num1 = int.Parse(Console.ReadLine());

        int num2 = int.Parse(Console.ReadLine());

        int num3 = int.Parse(Console.ReadLine());


        int maior = Maximo(num1, num2, num3); // AQUI FOI CRIADA UMA FUNÇÃO QUE VAI LER O MAIOR VALOR, CHAMADA "MAXIMO".

        System.Console.WriteLine(" ");
        System.Console.WriteLine($"O maior valor lido foi {maior}"); // Ponto01 - Saida dos dados informados / leitura dos valores.




    }

    static int Maximo(int A, int B, int C) // CRIAÇÃO DA FUNCÃO MÁXIMO, COM PASSAGEM DE 3 PARÂMETROS, OU SEJA, 3 NUMEROS QUE IREMOS LER.
    {
        int MaiorValor; // VARIÁVEL DECLARADA, PRONTA PARA RECEBER VALORES.


        if (A > B && A > C) // Se A (Primeiro numero) for maior que B (Segundo número) e A, for maior quer C (Terceiro número)
        {
            MaiorValor = A; // A variável maior valor irá receber o valor A
        }

        else if (B > A && B > C) // Se a primeira opção não for verdadeira: Se B for maior que A && B for maior que C
        {
            MaiorValor = B; // A variável receberá B

        }
        else // Senão (Se nenhuma das duas forem verdadeiras)
        {
            MaiorValor = C; // Maior valor será C

        }

        return MaiorValor; // ponto02: RETORNE A VARIÁVEL "MAIOR VALOR" COM OS VALORES DECLARADOS, PARA O ESCOPO PRINCIPAL.(RETORNO PARA O PONTO01) 













    }

}