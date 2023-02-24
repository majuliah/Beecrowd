using System;
using System.ComponentModel.Design;
using System.Globalization;
using static System.Console;

namespace Exercice1038
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice1038
            Menu();
            string[] answer = ReadLine().Split(' ');
            int order = int.Parse(answer[0]);
            int quantity = int.Parse(answer[1]);
            WriteLine($"{Exercice1038(order, quantity)}");
            
            //Exercice1039
        }
        static void Exercice103()
        {
            
        }   

        static void Menu()
        {
            WriteLine($"Hello! Welcome to sidewitch burgers!");
            WriteLine($"Take your order! Here is the menu: \n");
            
            WriteLine($"-----------------------------------------------------------------");
            WriteLine($"   CODE                    Order                       Value     ");
            WriteLine($"-----------------------------------------------------------------");
            WriteLine($"    1                      HotDog                      R$4.00    ");
            WriteLine($"    2                      X-Salad                     R$4.50    ");
            WriteLine($"    3                      X-Bacon                     R$5.00    ");
            WriteLine($"    4                      Simple Toast                R$2.00    ");
            WriteLine($"    5                      Soda                        R$1.50    ");
            WriteLine($"-----------------------------------------------------------------");
        }

        static string Exercice1038(int order, int quantity)
        {
            double value = 0.0;
            switch (order)
            {
                case 1:
                    value = 4.00;
                    break;
                case 2:
                    value = 4.50;
                    break;
                case 3:
                    value = 5.00;
                    break;
                case 4:
                    value = 2.00;
                    break;
                case 5:
                    value = 1.50;
                    break;
                default:
                    WriteLine($"Not an order");
                    break;
            }

            double total = quantity * value;
            return $"Total: {total.ToString($"F2", CultureInfo.InvariantCulture)}";
        }    
        
     
        static void Exercice10()
        {
            
        }        
        static void Exercice1()
        {
            
        }        
        static void Exercice()
        {
            
        }
    }
}