
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
            /*WriteLine($"Enter with X and Y numbers");
            string[] xAndY = ReadLine().Split();
            WriteLine($"{Exercice1041(double.Parse(xAndY[0]), double.Parse(xAndY[1]))}");
            */
            
            //Exercice1042
            /*WriteLine($"Enter with three numbers");
            string[] numbers = ReadLine().Split(' ');
            WriteLine($"{Exercice1042(int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]))}");
            */
            
            //Exercice 1043
            /*WriteLine($"Entre com três valores:");
            string[] numbers = ReadLine().Split(' ');
            WriteLine($"{Exercice1043(double.Parse(numbers[0], CultureInfo.InvariantCulture), double.Parse(numbers[1], CultureInfo.InvariantCulture), double.Parse(numbers[2], CultureInfo.InvariantCulture))}");
            */
            
            //Exercice 1044
            /*WriteLine($"Entre com dois inteiros");
            string[] numbers = ReadLine().Split(' ');
            WriteLine($"{Exercice1044(int.Parse(numbers[0]), int.Parse(numbers[1]))}");
            */
            
            //Exercice 1045
            WriteLine($"Entre com três valores:");
            string[] numbers = ReadLine().Split(' ');
            WriteLine($"{Exercice1045(double.Parse(numbers[0], CultureInfo.InvariantCulture), double.Parse(numbers[1], CultureInfo.InvariantCulture), double.Parse(numbers[2], CultureInfo.InvariantCulture))}");
            
        }

        static string Exercice1045(double a, double b, double c)
        {
            double maior = 0.0, meio = 0.0, menor = 0.0;
            string resposta = " ";
            
            if (a > b && a > c)
            {
                maior = a;
                if (b > c)
                {
                    meio = b;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = b;
                }
            }else if (b > a && b > c )
            {
                maior = b;
                if (a > c)
                {
                    meio = a;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = a;
                }
            }
            else
            {
                maior = c;
                if (a > b)
                {
                    meio = a;
                    menor = b;
                }
                else
                {
                    meio = b;
                    menor = a;
                }
            }

            if (maior >= (meio + menor))
              return resposta = "Não forma triângulo";
            
            if (Math.Pow(maior, 2.0) == Math.Pow(meio, 2.0) + Math.Pow(menor, 2.0))
                resposta += "Triângulo retângulo\n";
            if (Math.Pow(maior, 2.0) > Math.Pow(meio, 2.0) + Math.Pow(menor, 2.0))
                resposta += "Triângulo obtusângulo\n";
            if (Math.Pow(maior, 2.0) < Math.Pow(meio, 2.0) + Math.Pow(menor, 2.0))
                resposta += "Triângulo acutângulo\n";
            
            if (maior == meio && meio == menor)
                resposta += "Triângulo equilátero\n";
            else if (maior == menor || maior == meio || meio == menor)
                resposta += "Triângulo Isoceles\n";

            return resposta;
        }
        static string Exercice1044(int valor1, int valor2)
        {
            string resposta = " ";
            int divisao = 0;

            if (valor1 > valor2)
                divisao = valor1 % valor2;
            else
                divisao = valor2 % valor1;

            if (divisao == 0)
                resposta = $"São múltiplos";
            else
                resposta = $"Não são múltiplos";

            return resposta;

        }
        static string Exercice1043(double value1, double value2, double value3)
        {
            double resultado = 0.0;
            string resposta = "";
            
            if (value1 >= value2 + value3)
            {
                resultado = ((value1 + value2) * value3) / 2.0;
                resposta = $"Area = {resultado.ToString("F2", CultureInfo.InvariantCulture)}";
            }
            else
            {
                resultado = (value1 + value2 + value3);
                resposta = $"Perímetro = {resultado.ToString("F2", CultureInfo.InvariantCulture)}";
            }

            return resposta;
        }  
        static string Exercice1042(int number1, int number2, int number3)
        {
            int maior = 0;
            int meio = 0;
            int menor = 0;
            
            if (number1 > number2 && number1 > number3)
            {
                maior = number1;
                if (number2 > number3)
                {
                    meio = number2;
                    menor = number3;
                }
                else
                {
                    meio = number3;
                    menor = number2;
                }
            }
            else
            {
                menor = number1;
                if (number2 > number3)
                {
                    maior = number2;
                    meio = number3;
                }
                else
                {
                    maior = number3;
                    meio = number2;
                }
            }

            return $"{menor}\n{meio}\n{maior}\n\n\n{number1}\n{number2}\n{number3}";

        }     
        static double Exercice1013(double value1, double value2, double value3)
        {
            double maiorAB = (value1 + value2 + Math.Abs(value1 - value2)) / 2.0;
            double maiorABC = (maiorAB + value3 + Math.Abs(maiorAB - value3)) / 2.0;
            return maiorABC;
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
    }
}