using System;
using static System.Console;
using System.Globalization;

namespace Exercice1011
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercice1011
            /*WriteLine($"Valor do raio: ");
            double raio = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            WriteLine($"O volume da esfera ehr: {Exercice1011(raio).ToString($"F3", CultureInfo.InvariantCulture)}");
            */
            
            //exercice 1012
            /*WriteLine($"A, B, C: ");
            string[] abc;
            abc = ReadLine().Split(' ');
            double area = double.Parse(abc[0], CultureInfo.InvariantCulture);
            double baseCalc = double.Parse(abc[1], CultureInfo.InvariantCulture);
            double altura = double.Parse(abc[2], CultureInfo.InvariantCulture);
            WriteLine($"{Exercice1012(area, baseCalc, altura)}");
            */
            
            //exercice 1013
            
            
            
        }
        static double Exercice1011(double ray)
        {
            double pi = 3.14159;
            double esfera = (4.0 / 3.0) * pi * (Math.Pow(ray, 3));
            return esfera;
        }

        static string Exercice1012(double area, double b, double altura)
        {
            double pi = 3.14159;
            double trianguloRetangulo = (area * altura) / 2.0;
            double circulo = pi * (Math.Pow(altura, 2.0));
            double trapezio = (area + b) * (altura / 2.0);
            double quadrado = Math.Pow(b, 2.0);
            double retangulo = area * b;
            return ($"TRIANGULO: {trianguloRetangulo.ToString($"F2", CultureInfo.InvariantCulture)}" +
                    $" CIRCULO: {circulo.ToString($"F4", CultureInfo.InvariantCulture)}" +
                    $" TRAPEZIO: {trapezio.ToString($"F4", CultureInfo.InvariantCulture)}" +
                    $" QUADRADO: {quadrado.ToString($"F4", CultureInfo.InvariantCulture)}" +
                    $" RETANGULO: {retangulo.ToString($"F4", CultureInfo.InvariantCulture)}");
        }
        
        
    }
}