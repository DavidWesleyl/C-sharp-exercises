using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        // Determine qual é a maior área do triangulo (usando a fórmula de heron)
        // Area = SQRT(Raiz Quadrada) de  p * (p-a) * (p-b) * (p-c)  |  onde p = a + b + c / 2.0


        double x1, x2, x3, y1, y2, y3;



        Console.WriteLine("Digite as medidas de X abaixo: ", CultureInfo.InvariantCulture);

        x1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x3 = double.Parse((Console.ReadLine()), CultureInfo.InvariantCulture);

        Console.WriteLine(" ");

        double P_de_X = (x1 + x2 + x3) / 2.0; // Valor de P na Fórmula de Heron


        double Area_de_X = Math.Sqrt(P_de_X * (P_de_X - x1) * (P_de_X - x2) * (P_de_X - x3)); // Cálculo da àrea


        Console.WriteLine("Digite as medidas de Y abaixo: ");

        y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine(" ");


        double P_de_Y = (y1 + y2 + y3) / 2.0;

        double Area_de_Y = Math.Sqrt(P_de_Y * (P_de_Y - y1) * (P_de_Y - y2) * (P_de_Y - y3));


        Console.WriteLine(" ");

        Console.WriteLine($"A Área de X é {Area_de_X.ToString("f4", CultureInfo.InvariantCulture)}");
        Console.WriteLine($"A Área de Y é {Area_de_Y.ToString("f4", CultureInfo.InvariantCulture)}");

        Console.WriteLine(" ");

        if (Area_de_X > Area_de_Y)
        {
            Console.WriteLine("Maior Área: X");
        }
        else
        {
            Console.WriteLine("Maior Área: Y");
        }



        Console.WriteLine(" ")

    }
}
