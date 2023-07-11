using System;
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
            //WriteLine(Exercice1062);
            
            
        }

        static string Exercice1062()
        {
            
            
            return "";
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