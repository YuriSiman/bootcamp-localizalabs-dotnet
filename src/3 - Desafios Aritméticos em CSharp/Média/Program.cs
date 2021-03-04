using System;
using System.Globalization;

namespace Média
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, mediaP;

            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());

            a = Convert.ToDouble(a.ToString("F1"));
            b = Convert.ToDouble(b.ToString("F1"));

            mediaP = ((a * 3.5) + (b * 7.5)) / (3.5 + 7.5);

            Console.WriteLine("MEDIA = {0}", mediaP.ToString("0.00000", CultureInfo.InvariantCulture));
        }
    }
}
