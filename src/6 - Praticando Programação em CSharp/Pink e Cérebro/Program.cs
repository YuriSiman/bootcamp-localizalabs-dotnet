using System;
using System.Collections.Generic;

namespace Pink_e_Cérebro
{
    class Program
    {
        static void Main(string[] args)
        {
            var qtdNumeros = int.Parse(Console.ReadLine());
            string lista = Console.ReadLine();
            string[] numeros = lista.Split(' ');

            if (qtdNumeros < 1 || qtdNumeros > 1000) return;

            int multiplo2 = 0, multiplo3 = 0, multiplo4 = 0, multiplo5 = 0;

            for (int i = 0; i < qtdNumeros; i++)
            {
                var numero = int.Parse(numeros[i]);

                if (numero % 2 == 0) multiplo2 += 1;
                if (numero % 3 == 0) multiplo3 += 1;
                if (numero % 4 == 0) multiplo4 += 1;
                if (numero % 5 == 0) multiplo5 += 1;
            }
            Console.WriteLine($"{multiplo2} Multiplo(s) de 2\n" +
                $"{multiplo3} Multiplo(s) de 3\n" +
                $"{multiplo4} Multiplo(s) de 4\n" +
                $"{multiplo5} Multiplo(s) de 5");
        }
    }
}
