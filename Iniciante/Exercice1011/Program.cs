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
            WriteLine($"A, B, C: ");
            string[] calculos = ReadLine().Split(' ');
            WriteLine(Exercice1012(double.Parse(calculos[0], CultureInfo.InvariantCulture),double.Parse(calculos[1], CultureInfo.InvariantCulture),double.Parse(calculos[2], CultureInfo.InvariantCulture)));

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
            double trianguloRetangulo = b * altura / 2.0;
            double circulo = altura * Math.Pow(pi, 2);
            double trapezio = area + b * altura / 2.0;
            double quadrado = Math.Pow(b, 2);
            double retangulo = area * b;
            return ($"TRIANGULO: {trianguloRetangulo}" +
                    $"CIRCULO: {circulo}" +
                    $"TRAPEZIO: {trapezio}" +
                    $"QUADRADO: {quadrado}" +
                    $"RETANGULO: {retangulo}");
        }
        
        
    }
}