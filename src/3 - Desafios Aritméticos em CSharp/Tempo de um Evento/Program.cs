using System;

namespace Tempo_de_um_Evento
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaInicio, diaTermino, horaMomentoInicio, minutoMomentoInicio, segundoMomentoInicio;
            int horaMomentoTermino, minutoMomentoTermino, segundoMomentoTerminio;

            string[] dadosInicio = Console.ReadLine().Split(" ");
            diaInicio = Convert.ToInt32(dadosInicio[1]);

            string[] dadosMomentoInicio = Console.ReadLine().Split(":");
            horaMomentoInicio = Convert.ToInt32(dadosMomentoInicio[0]);
            minutoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[1]);
            segundoMomentoInicio = Convert.ToInt32(dadosMomentoInicio[2]);

            string[] dadosTermino = Console.ReadLine().Split(" ");
            diaTermino = Convert.ToInt32(dadosTermino[1]);

            string[] dadosMomentoTermino = Console.ReadLine().Split(":");
            horaMomentoTermino = Convert.ToInt32(dadosMomentoTermino[0]);
            minutoMomentoTermino = Convert.ToInt32(dadosMomentoTermino[1]);
            segundoMomentoTerminio = Convert.ToInt32(dadosMomentoTermino[2]);

            int Z = (segundoMomentoTerminio - segundoMomentoInicio);
            int Y = (minutoMomentoTermino - minutoMomentoInicio);
            int X = (horaMomentoTermino - horaMomentoInicio);
            int W = (diaTermino - diaInicio);

            if (Z < 0)
            {
                Z += 60;
                Y--;
            }

            if (Y < 0)
            {
                Y += 60;
                X--;
            }

            if (X < 0)
            {
                X += 24;
                W--;
            }

            Console.WriteLine("{0} dia(s)", W);
            Console.WriteLine("{0} hora(s)", X);
            Console.WriteLine("{0} minuto(s)", Y);
            Console.WriteLine("{0} segundo(s)", Z);
        }
    }
}
