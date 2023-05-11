using System;
using System.Globalization;

namespace Retangulo
{
    internal class CalculoRetangulo
    {
        public double Altura;
        public double Largura;


        public double Area()
        {
            return Altura * Largura; // Para calcular a Área de um retângulo, basta multiplicas a Base X Altura



        }

        public double Perimetro()
        {
            return (Altura + Largura) * 2.0; // Para calcular o Perimetro tem que somar a Base+ Altura e multiplicar por 2. P = 2 (b * a)
        }


        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2)); // Para calcular a Diagonal de um retangulo é A Raiz quadrada de B ^ 2 + A ^ 2
        }

        

    }
}
