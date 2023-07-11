using System;
using System.Globalization;
using static System.Console;

namespace Exercice1052
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            
            //Exercice1052
            //WriteLine(Exercice1052());
            
            //Exercice1059
            //WriteLine(Exercice1059());
            
            //Exercice1060
            //WriteLine(Exercice1060());
            
            //Exercice1061
            //WriteLine(Exercice1061());
            
            //Exercice1062
            //WriteLine(Exercice1062());    
            
            //Exercice1065
            //WriteLine(Exercice1065());
            
            //Exercice1066
            //WriteLine(Exercice1066());
            
            //Exercice1066;
            //WriteLine(Exercice1067());
            
            //Exercice1070
            //WriteLine(Exercice1070());
            
            //Exercice1071
            //WriteLine(Exercice1071());
            
            //Exercice1072
            WriteLine(Exercice1072());
        }

        static string Exercice1072()
        {
            WriteLine("Com quantos valores deseja entrar?");
            int total = int.Parse(ReadLine());
            int numberIn = 0;
            int numberOut = 0;
            int reading;
            
            WriteLine($"Entre com {total} números");
            
            for (int i = 0; i < total; i++)
            {
                Write($"- ");
                reading = int.Parse(ReadLine());
                if (reading >= 10 && reading <= 20)
                    numberIn += 1;
                else
                    numberOut += 1;
            }
            return ($"{numberIn} in\n{numberOut} out");
        }
        static string Exercice1071()
        {
            WriteLine("Entre com dois valores");
            Write("Valor 1: ");
            int value1 = int.Parse(ReadLine());
            
            Write("Valor 2: ");
            int value2 = int.Parse(ReadLine());

            int soma = 0;
            int value3 = 0;

            if (value1 > value2)
            {
                value3 = value1;
                value1 = value2;
                value2 = value3;
            }
            for (int i = value1; i < value2; i++)
            {
                if (i % 2 != 0)
                    soma += i;
            }
            return $"{soma}";
        }
        static string Exercice1070()
        {
            WriteLine("Enter with a number");
            int number = int.Parse(ReadLine());

            if (number % 2 == 0)
            {
                number += 1;
                WriteLine(number);
                for (int i = 0; i <= 4; i++)
                {
                    number += 2;
                    WriteLine(number);
                }
            }
            else
            {
                for (int i = 0; i <= 5; i++)
                {
                    number += 2;
                    WriteLine(number);
                }
            }
            return "";
        }
        static string Exercice1067()
        {
            WriteLine("Entre com um valor");
            int valor = int.Parse(ReadLine());

            if (valor >= 1 && valor <= 1000)
            {
                for (int i = 1; i <= valor; i++)
                {
                    if (i % 2 != 0)
                        WriteLine(i);
                }
            }
            else
                return ("Value out of range");

            return "";
        }
        static string Exercice1066()
        {
            WriteLine("Enter with 5 values");
            string numbers = ReadLine();
            string[] values = numbers.Split(' ');
            int par = 0;
            int impar = 0;
            int positivo = 0;
            int negativo = 0;

            foreach (var value in values)
            {
                if (int.Parse(value) < 0)
                    negativo += 1;
                else
                    positivo += 1;
                
                if (int.Parse(value) % 2 == 0)
                    par += 1;
                else
                    impar += 1;
            }
            return $"{par} valores pares\n" +
                   $"{impar} valores impares\n" +
                   $"{positivo} valores positivos\n" +
                   $"{negativo} valores negativos";
        }
        static string Exercice1065()
        {
            WriteLine("Enter with 5 values");
            string numbers = ReadLine();
            string[] values = numbers.Split(' ');
            double quantidade = 0;

            foreach (var value in values)
            {
                if (double.Parse(value, CultureInfo.InvariantCulture) % 2 == 0)
                    quantidade += 1;
            }
            return $"{quantidade} valores pares";
        }
        static string Exercice1062()
        {
            int quantidade = 0;
            double soma = 0.0;
            double media = 0.0;
            
            WriteLine("Enter 6 values");
            string numbers = ReadLine();
            string[] values = numbers.Split(' ');

            foreach (var value in values)
            {
                if (double.Parse(value, CultureInfo.InvariantCulture) > 0)
                {
                    quantidade += 1;
                    soma += double.Parse(value);
                }
            }
            media = soma / quantidade;
            return $"{quantidade} valores positivos\n{media.ToString("F1", CultureInfo.InvariantCulture)}";
        }
        static string Exercice1061()
        {
            Write("Dia: ");
            int diaInicio = int.Parse(ReadLine());
            string horaInicio = ReadLine();
            Write("Dia: ");
            int diaFim = int.Parse(ReadLine());
            string horaFim = ReadLine();

            string[] horasIniciais = horaInicio.Split(':');
            string[] horasFinais = horaFim.Split(':');
            
            DateTime diaInicial = new DateTime(2022, 04, diaInicio, int.Parse(horasIniciais[0]), int.Parse(horasIniciais[1]), int.Parse(horasIniciais[2]));
            DateTime diaFinal = new DateTime(2022, 04, diaFim, int.Parse(horasFinais[0]), int.Parse(horasFinais[1]), int.Parse(horasFinais[2]));

            TimeSpan total = diaFinal - diaInicial;

            return $"{total.Days} dia(s)\n{total.Hours} hora(s)\n{total.Minutes} minuto(s)\n{total.Seconds} segundo(s)";

        }
        static string Exercice1060()
        {
            int quantidade = 0;
            
            WriteLine("Enter 6 values");
            string numbers = ReadLine();
            string[] values = numbers.Split(' ');

            foreach (var value in values)
            {
                if (double.Parse(value) > 0)
                    quantidade += 1;
            }
            
            return $"{quantidade} valores positivos";
        }
        static string Exercice1059()
        {
            for (int i = 2; i <= 100; i++)
            {
                if (i % 2 == 0)
                    WriteLine(i);
            }
            return "";
        }
        static string Exercice1052()
        {
            WriteLine("Enter with a number of the month");
            int number = int.Parse(ReadLine());
            string month = "";

            switch (number)
            {
                case 1:
                    month = "January";
                    break;
                case 2:
                    month = "February";
                    break;                
                case 3:
                    month = "March";
                    break;                
                case 4:
                    month = "April";
                    break;
                case 5:
                    month = "May";
                    break;
                case 6:
                    month = "June";
                    break;                
                case 7:
                    month = "July";
                    break;
                case 8:
                    month = "August";
                    break;                
                case 9:
                    month = "September";
                    break;                
                case 10:
                    month = "October";
                    break;                
                case 11:
                    month = "November";
                    break;                
                case 12:
                    month = "December";
                    break;
                default:
                    month = "This is not a month";
                    break;
            }
            return month;
        }
    }
}