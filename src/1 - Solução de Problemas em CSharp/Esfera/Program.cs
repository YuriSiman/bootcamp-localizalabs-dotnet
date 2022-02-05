﻿using System.Globalization;

class DIO
{

    static void Main(string[] args)
    {

        double pi, raio, volume;
        pi = 3.14159;

        raio = double.Parse(Console.ReadLine());

        volume = (4 / 3.0) * pi * Math.Pow(raio, 3);

        Console.WriteLine($"VOLUME = {volume.ToString("F3", CultureInfo.InvariantCulture)}");
    }
}