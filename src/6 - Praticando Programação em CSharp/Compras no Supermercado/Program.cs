using System;
using System.Collections.Generic;

namespace Compras_no_Supermercado
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listas = new List<string>();
            var qtdlistas = int.Parse(Console.ReadLine());
            string[] listasFormatadas = new string[qtdlistas];

            for (int i = 0; i < qtdlistas; i++)
            {
                if (i > 100) return;
                string[] lista = Console.ReadLine().Split(" ");

                for (int j = 0; j < lista.Length; j++)
                {
                    if (j > 1000) return;
                    lista[j] = lista[j].ToLower();

                    string comAcentos = "äáâàãéêëèíîïìöóôòõüúûùç", semAcentos = "aaaaaeeeeiiiiooooouuuuc";

                    for (int k = 0; k < comAcentos.Length; k++)
                    {
                        lista[j] = lista[j].Replace(comAcentos[k].ToString(), semAcentos[k].ToString());
                    }

                    if (!listas.Contains(lista[j])) listas.Add(lista[j]);
                }
                listas.Sort();
                listasFormatadas[i] = string.Join(" ", listas);
                listas.Clear();
            }

            for (int i = 0; i < qtdlistas; i++)
            {
                Console.WriteLine(listasFormatadas[i]);
            }
        }
    }
}
