using System;
using System.Globalization;

namespace Coordenadas_de_um_Ponto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas = Console.ReadLine().Split(" ");

            double x = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            double y = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (x == 0.0 && y == 0.0) Console.WriteLine("Origem");

            if (x == 0.0 && y != 0.0) Console.WriteLine("Eixo Y");

            if (x != 0.0 && y == 0.0) Console.WriteLine("Eixo X");

            if (x > 0.0 && y > 0.0) Console.WriteLine("Q1");

            if (x < 0.0 && y > 0.0) Console.WriteLine("Q2");

            if (x < 0.0 && y < 0.0) Console.WriteLine("Q3");

            if (x > 0.0 && y < 0.0) Console.WriteLine("Q4");

        }
    }
}
