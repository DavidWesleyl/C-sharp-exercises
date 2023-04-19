using System;
using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        /* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e 
        mostre: 
        a) a área do triângulo retângulo que tem A por base e C por altura. 
        b) a área do círculo de raio C. (pi = 3.14159) 
        c) a área do trapézio que tem A e B por bases e C por altura. 
        d) a área do quadrado que tem lado B. 
        e) a área do retângulo que tem lados A e B */


        /* fórmulas: Para calcularmos a área de um triangulo retangulo, multiplicamos seus catetos (A e C) e dividimos por 2.
           > Para calcularmos a área de um ciculo: é o raio C ao quadrado, multiplicado por PI.
           > Para calcularmos a área de um trapézio é necessário somar as bases, multiplicar pela altura e dividir por 2.
           > Para calcularmos o lado de um quadrado, como todos os lados são iguais, basta pegar um e eleva-lo ao quarado. Nesse caso o lado B
           > Para calcularmos a área do retangulo é só multiplicar a área pela altura.
        */



        string[] numeros = Console.ReadLine().Split(' ');


        float A = float.Parse(numeros[0], CultureInfo.InvariantCulture);
        float B = float.Parse(numeros[1], CultureInfo.InvariantCulture);
        float C = float.Parse(numeros[2], CultureInfo.InvariantCulture);


        float Calculo_Area = (A * C) / 2;

        double Calculo_Circulo = (Math.Pow(C, 2)) * 3.14159;

        float Calculo_Trapezio = (A + B) * (C) / 2;

        double Calculo_Quadrado = Math.Pow(B, 2.0);

        float Calculo_Retangulo = A * B;



        System.Console.WriteLine(" ");

        System.Console.WriteLine($"Area Triangulo Retangulo: {Calculo_Area.ToString("f3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"Área Circulo: {Calculo_Circulo.ToString("f3", CultureInfo.InvariantCulture)} ");
        System.Console.WriteLine($"Área do Trapézio: {Calculo_Trapezio.ToString("f3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"Lado do quadrado: {Calculo_Quadrado.ToString("f3", CultureInfo.InvariantCulture)}");
        System.Console.WriteLine($"Área do Retangulo: {Calculo_Retangulo.ToString("f3", CultureInfo.InvariantCulture)}");

        System.Console.WriteLine(" ");







    }
}