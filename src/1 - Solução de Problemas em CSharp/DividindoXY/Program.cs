using System.Globalization;

class Desafio
{
    static void Main()
    {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++)
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y != 0)
            {
                double resultado = X / Y;
                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("divisao impossivel");
            }
        }
    }
}