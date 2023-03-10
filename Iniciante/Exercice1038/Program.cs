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
            /*Menu();
            string[] answer = ReadLine().Split(' ');
            int order = int.Parse(answer[0]);
            int quantity = int.Parse(answer[1]);
            WriteLine($"{Exercice1038(order, quantity)}");
            */
            
            //Exercice1040
            /*WriteLine($"Enter with 4 numbers for the students note:");
            string[] notas = ReadLine().Split(' ');
            WriteLine($"{Exercice1040(double.Parse(notas[0]), double.Parse(notas[1]), double.Parse(notas[2]),double.Parse(notas[3]))}");
            */
            
            //Exercice1041
            WriteLine($"Enter with X and Y numbers");
            string[] xAndY = ReadLine().Split();
            WriteLine($"{Exercice1041(double.Parse(xAndY[0]), double.Parse(xAndY[1]))}");
            
        }

        static string Exercice1041(double eixoX, double eixoY)
        {
            string result = $" ";

            if (eixoX == 0.0 && eixoY == 0.0)
                result = $"Origem";
            else if (eixoX > 0.0 & eixoY > 0.0)
                result = $"Q1";
            else if (eixoX < 0.0 & eixoY > 0.0)
                result = $"Q2";
            else if (eixoX > 0.0 & eixoY < 0.0)
                result = $"Q4";
            else
                result = $"Q3";
            return result;
        
        }

        static string Exercice1040(double n1, double n2, double n3, double n4)
        {
            double primeiraMedia = (n1 * 2.0 + n2 * 3.0 + n3 * 4.0 + n4 * 1.0) / 10.0;
            string answer = " ";
            double segundaMedia = 0.0;
            
            if (primeiraMedia >= 7.0 & primeiraMedia <= 10.0)
                answer = $"Média: {primeiraMedia.ToString($"F2", CultureInfo.InvariantCulture)} \nAluno Aprovado!";
            else if (primeiraMedia < 5.0 & primeiraMedia > 0.0)
                answer = $"Média: {primeiraMedia.ToString($"F2", CultureInfo.InvariantCulture)} \nAluno Reprovado!";
            else
            {
                WriteLine($"Aluno em exame. \nNota do Exame:");
                segundaMedia = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                double calculoFinal = (primeiraMedia + segundaMedia) / 2.0;
                
                if (calculoFinal >= 5.0 & calculoFinal <= 10.0)
                    answer =
                        $"Aluno aprovado.\nMédia Final: {calculoFinal.ToString($"F2", CultureInfo.InvariantCulture)}";
                else
                    answer = $"Aluno reprovado com média final.\nMédia Final: {calculoFinal.ToString($"F2", CultureInfo.InvariantCulture)}";
                
            }
            return answer;
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