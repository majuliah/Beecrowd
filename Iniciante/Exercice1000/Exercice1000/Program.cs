using System;
using System.Globalization;
using static System.Console;

namespace Exercice1000
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercice 1000
            WriteLine(Message());

            //exercice 1001
            /*WriteLine($"Enter with two numbers: ");
            int numberOne = int.Parse(ReadLine());
            int numberTwo = int.Parse(ReadLine());
            WriteLine($"X = {Exercice1001(numberOne, numberTwo)}"); */
            
            //exercice 1002
            /*WriteLine($"Enter with a number for radios (double precision:)");
            double radios = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            WriteLine($"Area = {Exercice1002(radios).ToString($"F4", CultureInfo.InvariantCulture)}");*/
            
            //exercice 1003
            

        }
        public static string Message()
        {
            string hello = $"Hello Guys";
            return hello;
            //exercice 1000
        }
        public static int Exercice1001(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            return result;
        }
        
        public static double Exercice1002(double radios)
        {
            double pi = 3.14159;
            double area = pi * (Math.Pow(radios, 2.0));
            return area;
        }
    }
}