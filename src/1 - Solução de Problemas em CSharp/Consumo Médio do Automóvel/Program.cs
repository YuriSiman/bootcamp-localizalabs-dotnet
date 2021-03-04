using System;

namespace Consumo_Médio_do_Automóvel
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia;
            double combustivelGasto, consumoMedio;

            Console.Write("Informe a distância: ");
            distancia = Convert.ToInt32(Console.ReadLine());
            Console.Write("Informe o combustível gasto: ");
            combustivelGasto = Convert.ToDouble(Console.ReadLine());

            consumoMedio = distancia / combustivelGasto;

            Console.WriteLine("O consumo médio é de {0:0.000} km/l", consumoMedio);
        }
    }
}
