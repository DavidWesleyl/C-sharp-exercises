internal class Program
{
    private static void Main(string[] args)
    {
        /* Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
            Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando 
            essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)*/


        Console.Write("Digite os valores para saber se ele está no intervalor entre [10, 20]: ");
        int valor = int.Parse(Console.ReadLine());

        int contador_Dentro = 0;
        int contador_Fora = 0;



        for (int numeros = 1; numeros <= valor; numeros++)
        {
            Console.Write($"Digite o valor de numero {numeros}: ");
            int ValoresIntervalo = int.Parse(Console.ReadLine());

            if (ValoresIntervalo >= 10 && ValoresIntervalo <= 20)
            {
                contador_Dentro += 1;
            }
            else
            {
                contador_Fora += 1;
            }

            

        }
        
        Console.WriteLine($"{contador_Dentro} in | {contador_Fora} out");























    }
}