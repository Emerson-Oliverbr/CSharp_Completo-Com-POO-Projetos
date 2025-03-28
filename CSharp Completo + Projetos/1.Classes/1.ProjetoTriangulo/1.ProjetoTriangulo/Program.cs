﻿using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA, xB,xC, yA, yB, yC;

            Console.WriteLine("Entre copm as medidas do triangulo X: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre copm as medidas do triangulo Y: ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine($"Area de X = {areaX.ToString("F4",CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if(areaX > areaY)
            {
                Console.WriteLine("Maior area: X");
            } else
            {
                Console.WriteLine("Maior area: Y");
            }

                Console.ReadKey();
        }
    }
}