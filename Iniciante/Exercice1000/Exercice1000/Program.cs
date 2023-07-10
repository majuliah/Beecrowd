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
            /*WriteLine($"Enter with two numbers: ");
            int numberOne = int.Parse(ReadLine());
            int numberTwo = int.Parse(ReadLine());
            WriteLine($"SOMA = {Exercice1003(numberOne, numberTwo)}");
            */
            
            //exercice 1004
            /*
            WriteLine($"Enter with two numbers: ");
            double numberOne = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            double numberTwo = double.Parse(ReadLine(), CultureInfo.InvariantCulture));
            WriteLine($"PRODUTO = {Exercice1004(numberOne, numberTwo)}");
            */
            
            //exercice 1005
            /*WriteLine($"Enter with two numbers: ");
            double numberOne = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            double numberTwo = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            WriteLine($"MEDIA = {Exercice1005(numberOne, numberTwo)}");     
            */      
            
            //exercice 1006
            /*WriteLine($"Enter with three numbers: ");
            double numberOne = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            double numberTwo = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            double numberThree = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            WriteLine($"MEDIA = {Exercice1006(numberOne, numberTwo, numberThree).ToString($"F2", CultureInfo.InvariantCulture)}");
            */
            
            //exercice1007
            /*WriteLine($"Enter with four numbers: ");
            int numberOne = int.Parse(ReadLine());
            int numberTwo = int.Parse(ReadLine());
            int numberThree = int.Parse(ReadLine());
            int numberFour = int.Parse(ReadLine());
            WriteLine($"DIFERENÇA = {Exercice1007(numberOne, numberTwo, numberThree, numberFour)}");
            */
            
            //exercice 1008
            /*WriteLine($"Enter with an ID, a total of hours and the value hour: ");
            int id = int.Parse(ReadLine());
            double hours = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            double valueHour = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            WriteLine($"NUMBER = {id}" +
                      $"SALARY = {Exercice1008(id, hours, valueHour)}");
            */
            
            //exercice 1009
            /*WriteLine($"Enter with an name, salary and, total of sells: ");
            string name = ReadLine();
            double salary = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            double valueSells = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            WriteLine($"Name = {name}" +
                      $"SALARY = {Exercice1009(salary, valueSells).ToString($"F2", CultureInfo.InvariantCulture)}");
            */
            
            //exercice1010
            WriteLine($"Enter with a code, number os peaces and the value of each peace: ");
            string[] values1 = ReadLine().Split(' ');
            string[] values2 = ReadLine().Split(' ');
            WriteLine($"VALUE TO PAY = R${Exercice1010(int.Parse(values1[1]),double.Parse(values1[2], CultureInfo.InvariantCulture), int.Parse(values2[1]), double.Parse(values2[2], CultureInfo.InvariantCulture))}");
             
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
        public static int Exercice1003(int number1, int number2)
        {
            int sum = 0;
            
            if (number1 == 0 && number2 == 0)
                WriteLine($"You have to give at least one number different than 0. ");
            else
                sum = number1 + number2;
            
            return sum;
        }
        public static double Exercice1004(double number1, double number2)
        {
            double product = 0.0;

            if (number1 == 0 && number2 == 0)
                WriteLine($"You have to give at least one number different than 0. ");
            else
                product = number1 * number2;
            
            return product;
            
        }
        public static double Exercice1005(double number1, double number2)
        {
            double media = 0.0;

            if (number1 == 0 && number2 == 0)
                WriteLine($"You have to give at least one number different than 0. ");
            else
                media = number1 * 3.5 + number2 * 7.5 / 11.0;
            
            return media;
        }        
        public static double Exercice1006(double number1, double number2, double number3)
        {
            double media = 0.0;

            if (number1 == 0.0 && number2 == 0.0 && number3 == 0.0)
                WriteLine($"You have to give at least one number different than 0. ");
            else
                media = (number1 * 2.0 + number2 * 3.0 + number3 * 5.0) / 10.0;
            
            return media;
        }
        public static int Exercice1007(int number1, int number2, int number3, int number4)
        {
            int diferenca = number1 * number2 - number3 * number4;
            return diferenca;
        }

        public static double Exercice1008(int number, double hour, double valueHour)
        {
            double totalSalary = hour * valueHour;
            return totalSalary;
        }

        public static double Exercice1009(double salary, double sells)
        {
            double totalSalary = salary + (sells * 0.15);
            return totalSalary;
        }
        public static double Exercice1010(int number1, double value1, int number2, double value2)
        {
            double valueTotal = (number1 * value1) + (number2 * value2);
            return valueTotal;
        }
        
    }
}