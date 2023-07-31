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
            
            //Exercice1080
            //Exercice1080();
            
            //Exercice1094
            //Exercice1094();
            
            //Exercice1095
            //Exercicice1095();
            
            //Exercice1096
            //Exercice1096();
            
            //Exercice1097
            //Exercice1097();
            
            //Exercice1098
            //Exercice1098();
            
            //Exercice1113
            //Exercice1113();
            
            //Exercice1114
            Exercice1114();

        }


        static void Exercice1114()
        {
            string senha = "2002";
            WriteLine("Tente advinhar a senha: ");
            Write("Senha: ");
            string advinha = "";
            do
            {
                advinha = ReadLine();
                if (advinha != senha)
                    WriteLine("Senha Inválida");
            } while (advinha != senha);
            
            WriteLine("Acesso Permitido");
            
        }
        static void Exercice1113()
        {
            WriteLine("Entre com dois números");
            string numeros = ReadLine();
            int numero1 = int.Parse(numeros.Split(' ')[0]);
            int numero2 = int.Parse(numeros.Split(' ')[1]);

            if (numero1 > numero2)
                WriteLine("Decrescente");
            else if (numero1 < numero2)
                WriteLine("Crescente");
            else
                Clear();

        }
        static void Exercice1098()
        {
            double i = 0;
            while (i <= 2)
            {
                for (int k = 1; k <= 3; k++)
                {
                    if (i == 0)
                    {
                        WriteLine($"I = {i} J = {(k + i).ToString(CultureInfo.InvariantCulture)}");
                    }
                    else if (i == 1)
                    {
                        WriteLine($"I = {i} J = {(k + i).ToString(CultureInfo.InvariantCulture)}");
                    }
                    else if (i == 2 || i == 2.0)
                    {
                        WriteLine($"I = {i.ToString().Remove(1,1)} J = {(k + i).ToString(CultureInfo.InvariantCulture)}");
                    }
                    else
                    {
                        WriteLine(
                            $"I = {i.ToString("F1", CultureInfo.InvariantCulture)} J = {(k + i).ToString("F1",CultureInfo.InvariantCulture)}");
                    }
                }
                i += 0.2;
            }
        }
        static void Exercice1097()
        {
            int m = 7;
            int n;
            for (int i = 1; i <= 9; i += 2)
            {
                n = m;
                for (int j = 1; j <= 3; j++)
                {
                    WriteLine($"I={i} J= {n}");
                    n--;
                }
                m += 2;
            }
        }
        static void Exercice1096()
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 7; j >= 5; j--)
                {
                    WriteLine($"I={i} J={j}");
                }
            }
        }
        static void Exercicice1095()
        {
            int j = 60;
            int i = 1;
            for (int a = 1; a <= 13; a++)
            {
                WriteLine($"I = {i} J = {j}");
                j -= 5;
                i += 3;
            }
        }
        static void Exercice1094()
        {
            int qtdeSapo = 0;
            int qtdeRato = 0;
            int qtdeCoelho = 0;
            int quantidadeCobaias = 0;
            string amostra;
            char tipoAnimal;
            
            short quantidadeTestes;
            WriteLine("Quantos testes deseja realizar?");
            quantidadeTestes = short.Parse(ReadLine());

            for (int i = 0; i < quantidadeTestes; i++)
            {
                amostra = ReadLine();
                quantidadeCobaias += int.Parse(amostra.Split(' ')[0]);
                tipoAnimal = char.Parse(amostra.Split(' ')[1].ToUpper());

                switch (tipoAnimal)
                {
                    case 'S':
                        qtdeSapo += int.Parse(amostra.Split(' ')[0]);
                        break;
                    case 'R':
                        qtdeRato += int.Parse(amostra.Split(' ')[0]);
                        break;
                    case 'C':
                        qtdeCoelho += int.Parse(amostra.Split(' ')[0]);
                        break;
                }
            }
            
            double percentualCoelho = (double)qtdeCoelho / quantidadeCobaias;
            double percentualRatos = (double)qtdeRato / quantidadeCobaias;
            double percentualSapos = (double)qtdeSapo / quantidadeCobaias;
            
            WriteLine($"Total: {quantidadeCobaias}");
            WriteLine($"Total de coelhos: {qtdeCoelho}");
            WriteLine($"Total de ratos: {qtdeRato}");
            WriteLine($"Total de sapos: {qtdeSapo}");
            WriteLine($"Percentual de coelhos: {percentualCoelho.ToString("F2", CultureInfo.InvariantCulture)}");
            WriteLine($"Percentual de ratos: {percentualRatos.ToString("F2", CultureInfo.InvariantCulture)}");
            WriteLine($"Percentual de sapos: {percentualSapos.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
        static void Exercice1080()
        {
            int numbers, maior = 0, posicao = 0;
            WriteLine("Enter with the numbers");
            for (int i = 0; i < 100; i++)
            {
                numbers = int.Parse(ReadLine());
                if (numbers > maior)
                {
                    maior = numbers;
                    posicao = i + 1;
                }
            }
            WriteLine();
            WriteLine($"Maior: {maior}\nPosição: {posicao}");
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
