using System;

namespace Bazinga_
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++)
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0].ToUpper();
                v2 = valores[1].ToUpper();
                if ((v1 == "TESOURA" && v2 == "PAPEL") || (v1 == "PAPEL" && v2 == "PEDRA") || (v1 == "PEDRA" && v2 == "LAGARTO") ||
                    (v1 == "LAGARTO" && v2 == "SPOCK") || (v1 == "SPOCK" && v2 == "TESOURA") || (v1 == "TESOURA" && v2 == "LAGARTO") ||
                    (v1 == "LAGARTO" && v2 == "PAPEL") || (v1 == "PAPEL" && v2 == "SPOCK") || (v1 == "SPOCK" && v2 == "PEDRA") ||
                    (v1 == "PEDRA" && v2 == "TESOURA"))
                    Console.WriteLine("Caso #{0}: Bazinga!", i);
                else if (v1 == v2)
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }

        }
    }
}
