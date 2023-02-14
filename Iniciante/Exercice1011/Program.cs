using System;
using System.Diagnostics.CodeAnalysis;
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
            /*WriteLine($"Entre com 3 valores");
            string[] abc;
            abc = ReadLine().Split(' ');
            double value1 = double.Parse(abc[0], CultureInfo.InvariantCulture);
            double value2 = double.Parse(abc[1], CultureInfo.InvariantCulture);
            double value3 = double.Parse(abc[2], CultureInfo.InvariantCulture);
            WriteLine($"Maior eh: {Exercice1013(value1, value2, value3)}");
            */
            
            //exercice1014
            /*WriteLine($"Enter with the total of Km");
            double totalKm = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            double totalGas = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            WriteLine($"average consumption: {Exercice1014(totalKm, totalGas).ToString($"F3", CultureInfo.InvariantCulture)} km/l");
            */
            
            //exercice1015
            /*double x1, x2, y1, y2;
            WriteLine($"Enter with x1 and y1");
            string[] values = ReadLine().Split(' ');
            x1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(values[1], CultureInfo.InvariantCulture);WriteLine($"Enter with x1 and y1");
            
            WriteLine($"Enter with x2 and y2");
            values = ReadLine().Split(' ');
            x2 = double.Parse(values[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(values[1], CultureInfo.InvariantCulture);
            
            WriteLine($"Distance between 2 points: {Exercice1015(x1, x2, y1, y2).ToString($"F4", CultureInfo.InvariantCulture)}");
            */
            
            //exercice1016
            /*WriteLine($"Enter with the distance");
            double distancia = double.Parse(ReadLine(), CultureInfo.CurrentCulture);
            WriteLine($"{Exercice1016(distancia)} minutos");
            */
            
            //ercice1017
            WriteLine($"Enter with a spent time and avarege speed: ");
            double time = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            double avaregeVelocity = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            WriteLine($"Total Litros: {Exercice1017(time, avaregeVelocity).ToString($"F3", CultureInfo.InvariantCulture)}");
        }

        static double Exercice1017(double time, double avaregeVelocity)
        {
            double kmPorLitro = 12.0;
            double TotalLitros = (time * avaregeVelocity) / kmPorLitro;
            return TotalLitros;
        }
        static double Exercice1016(double distancia)
        {
            return distancia * 2;
        }
        
        static double Exercice1015(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));
            return distance;
        }
        
        static double Exercice1014(double totalKm, double totalGas)
        {
            return totalKm / totalGas;
        }
        
        static double Exercice1013(double value1, double value2, double value3)
        {
            double maiorAB = (value1 + value2 + Math.Abs(value1 - value2)) / 2.0;
            double maiorABC = (maiorAB + value3 + Math.Abs(maiorAB - value3)) / 2.0;
            return maiorABC;
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
        static double Exercice1011(double ray)
        {
            double pi = 3.14159;
            double esfera = (4.0 / 3.0) * pi * (Math.Pow(ray, 3));
            return esfera;
        }
        
    }
}