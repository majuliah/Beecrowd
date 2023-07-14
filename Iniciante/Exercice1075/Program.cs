using System;
using System.Globalization;
using static System.Console;

namespace Exercice1075
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice1075
            //Exercice1075();
            
            //Exercice1078
            //Exercice1078();
            
            //Exercice1079
            //Exercice1079();
        }

        static void Exercice1075()
        {
            WriteLine("Enter with a number");
            short number = short.Parse(ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % number == 2)
                    WriteLine(i);
            }
            
        }
        static void Exercice1078()
        {
            short number = 0;
            do
            {
                WriteLine("Enter with a number");
                number = short.Parse(ReadLine());
            } while (number < 2 & number >= 1000);

            for (int i = 1; i <= 10; i++)
                WriteLine($"{i} x {number} = {i * number}");
        }
        static void Exercice1079()
        {
            WriteLine("How many tests do you want to do?");
            short test = short.Parse(ReadLine());
            string[] numbers = new string[3];
            double[] medias = new double[test];

            for (int i = 0; i < test; i++)
            {
                numbers = ReadLine().Split(' ');
                double media = (double.Parse(numbers[0], CultureInfo.InvariantCulture) * 2.0 
                                + double.Parse(numbers[1], CultureInfo.InvariantCulture) * 3.0  
                                + double.Parse(numbers[2], CultureInfo.InvariantCulture) * 5.0) / 10.0;
                medias[i] = media;
            }

            foreach (double number in medias)
                WriteLine($"{number.ToString("F1", CultureInfo.InvariantCulture)}");
            
        }
    }
}
