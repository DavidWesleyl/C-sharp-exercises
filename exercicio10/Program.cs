internal class Program
{
    private static void Main(string[] args)
    {
        /* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
           começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.*/


        System.Console.Write("Digite a hora inicial e a hora final do jogo: ");

        string[] Horario_do_Jogo = Console.ReadLine().Split(' ');

        int Inicio = int.Parse(Horario_do_Jogo[0]);
        int Final = int.Parse(Horario_do_Jogo[1]);

        int duracao;

        if (Inicio < Final)
        {
            duracao = Final - Inicio;
            System.Console.WriteLine($"O jogo durou {duracao}:00h");
        }

        else

        {
            duracao = 24 - Inicio + Final;

            System.Console.WriteLine($"O Jogo durou {duracao}:00h ");

        }











    }
}