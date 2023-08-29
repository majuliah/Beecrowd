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
            
            //Exercice1099
            //Exercice1099();
            
            //Exercice1011
            //Exercice1101();
            
            //Exercice1113
            //Exercice1113();
            
            //Exercice1114
            //Exercice1114();
            
            //Exercice1115
            //Exercice1115();
            
            //Exercice1116
            //Exercice1116();
            
            //Exercice1117
            //Exercice1117();
            
            //Exercice1118
            //Exercice1118();
            
            //Exercice1131
            //Exercice1131();
            
            //Exercice1132
            //Exercice1132();
            
            //Exercice1133
            //Exercice1133();
            
            //Exercice1134
            //Exercice1134();
            
            //Exercice1142
            //Exercice1142();
            
            //Exercice1143
            Exercice1143();
            
            
        }


        static void Exercice1143()
        {
            WriteLine("Entre com um número inteiro");
            int linhas = int.Parse(ReadLine());
            int contador = 1;
            
            for (int i = 0; i < linhas; i++)
            {
                WriteLine($"{contador} {Math.Pow(contador, 2)} {Math.Pow(contador, 3)}");
                contador += 1;
            }
        }
        static void Exercice1142()
        {
            WriteLine("Entre com um número positivo inteiro");
            int numero = int.Parse(ReadLine());
            int contagem = 1;

            for (int i = 0; i < numero; i++)
            {
                WriteLine($"{contagem} {contagem + 1} {contagem + 2} PUM");
                contagem += 4;
            }
            
        }
        static void Exercice1134()
        {
            int alcool = 0, gasolina = 0, diesel = 0, tipocombustivel;
            bool escolha = true;
            

            while (escolha)
            {
                tipocombustivel = int.Parse(ReadLine());
                switch (tipocombustivel)
                {
                    case 1:
                        alcool += 1;
                        break;
                    case 2:
                        gasolina += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                    case 4:
                        escolha = false;
                        break;
                    default:
                        escolha = true;
                        break;
                }
            }
            WriteLine("MUITO OBRIGADO");
            WriteLine($"Alcool: {alcool}");
            WriteLine($"Gasolina: {gasolina}");
            WriteLine($"Diesel: {diesel}");


        }
        static void Exercice1133()
        {
            WriteLine("Entre com dois valores inteiros");
            int value1 = int.Parse(ReadLine());
            int value2 = int.Parse(ReadLine());

            if (value1 < value2)
            {
                for (int i = value1; i < value2; i++)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                        WriteLine(i);
                }
            }
            else
            {
                for (int i = value1; i > value2; i--)
                {
                    if (i % 5 == 2 || i % 5 == 3)
                        WriteLine(i);
                }
            }
        }
        static void Exercice1132()
        {
            WriteLine("Entre com dois valores inteiros");
            int value1 = int.Parse(ReadLine());
            int value2 = int.Parse(ReadLine());
            int soma = 0;

            if (value1 < value2)
            {
                for (int i = value1; i <= value2; i++)
                {
                    if (i % 13 != 0 )
                        soma += i;
                }
            }
            else
            {
                for (int i = value1; i >= value2; i--)
                {
                    if (i % 13 != 0 )
                        soma += i;
                }
            }
            
            WriteLine(soma);
            
        }
        static void Exercice1131()
        {
            short resposta = 1;
            int inter = 0, gremio = 0, empates = 0, grenais = 0;

            do
            {
                string[] placar = new string[2];
                placar = ReadLine().Split(' ');

                if (int.Parse(placar[0]) > int.Parse(placar[1]))
                {
                    inter += 1;
                }else if (int.Parse(placar[0]) < int.Parse(placar[1]))
                {
                    gremio += 1;
                }
                else
                {
                    empates += 1;
                }
                grenais += 1;
                
                WriteLine("Novo grenal 1-sim 2-nao");
                resposta = short.Parse(ReadLine());

            } while (resposta == 1);
            
            WriteLine($"{grenais} grenais");
            WriteLine($"Inter: {inter}");
            WriteLine($"Gremio: {gremio}");
            WriteLine($"Empates: {empates}");

            if (empates > inter & empates > gremio)
                WriteLine("Empate");
            else if (inter < gremio)
                WriteLine("Gremio venceu mais");
            else if (inter > gremio)
                WriteLine("Inter venceu mais");
        }
        static void Exercice1118()
        {
            short resposta = 0;
            do
            { 
                double nota1 = -1.0;
                double nota2 = -1.0;
                
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    nota1 = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    if (nota1 < 0.0 || nota1 > 10.0)
                        WriteLine("Nota inválida");
                }
                
                while (nota2 < 0.0 || nota2 > 10.0)
                {
                    nota2 = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                    if (nota2 < 0.0 || nota2 > 10.0)
                        WriteLine("Nota inválida");
                }

                double media = (nota1 + nota2) / 2.0;
                WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
                
                WriteLine("Novo Calculo 1-sim 2-nao"); 
                resposta = short.Parse(ReadLine());
                
                while (resposta != 1 & resposta != 2)
                { 
                    WriteLine("Novo Calculo 1-sim 2-nao"); 
                    resposta = short.Parse(ReadLine());        
                }

            } while (resposta == 1);
        }
        static void Exercice1117()
        {
            double nota1 = -1.0;
            double nota2 = -1.0;

            while (nota1 < 0.0 || nota1 > 10.0)
            {
                nota1 = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                if (nota1 < 0.0 || nota1 > 10.0)
                    WriteLine("Nota inválida");
            }
            
            while (nota2 < 0.0 || nota2 > 10.0)
            {
                nota2 = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                if (nota2 < 0.0 || nota2 > 10.0)
                    WriteLine("Nota inválida");
            }

            double media = (nota1 + nota2) / 2.0;
            WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");
            
        }
        static void Exercice1116()
        {
            WriteLine("Quantas verificações deseja fazer?");
            short vezes = short.Parse(ReadLine());
            string numeros = "";
            int num1, num2;
            double divisao = 0.0;

            for (int i = 0; i < vezes; i++)
            {
                numeros = ReadLine();
                num1 = int.Parse(numeros.Split(' ')[0]);
                num2 = int.Parse(numeros.Split(' ')[1]);

                if (num2 != 0)
                {
                    divisao = (double)num1 / (double)num2;
                    WriteLine($"{divisao.ToString("F1", CultureInfo.InvariantCulture)}");
                }
                else
                    WriteLine("divisão impossível");
                
            }
        }
        static void Exercice1115()
        {
            string[] quadrante = new string[2];
            WriteLine("Entre com os quadrantes");
            quadrante = ReadLine().Split(' ');
            
            if (int.Parse(quadrante[0]) > 0 && int.Parse(quadrante[1]) > 0)
                WriteLine("primeiro");
            else if (int.Parse(quadrante[0]) > 0 && int.Parse(quadrante[1]) < 0)
                WriteLine("quarto");
            else if (int.Parse(quadrante[0]) < 0 && int.Parse(quadrante[1]) < 0)
                WriteLine("terceiro");
            else if (int.Parse(quadrante[0]) < 0 && int.Parse(quadrante[1]) > 0)
                WriteLine("Segundo");
            else
                Write("");
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
        static void Exercice1101()
        {
            string[] numbers = new string[2];
            numbers = ReadLine().Split(' ');

            int min, max, soma = 0;

            if (int.Parse(numbers[0]) > int.Parse(numbers[1]))
            {
                min = int.Parse(numbers[1]);
                max = int.Parse(numbers[0]);
            }
            else
            {
                min = int.Parse(numbers[0]);
                max = int.Parse(numbers[1]);
            }

            if (min != 0 && max != 0)
            {
                for (int i = min; i <= max; i++)
                {
                    soma += i;
                    Write($"{i} ");
                }
                Write($"Sum={soma}");
            }
        }
        static void Exercice1099()
        {
            string[] numbers = new string[2];
            WriteLine("Qauntos testes deseja fazer?");
            short testes = short.Parse(ReadLine());
            int soma = 0;

            for (int i = 0; i < testes; i++)
            {
                int maior, menor;
                
                WriteLine("Entre com os números");
                numbers = ReadLine().Split(' ');

                if (int.Parse(numbers[0]) < int.Parse(numbers[1]))
                {
                    maior = int.Parse(numbers[0]);
                    menor = int.Parse(numbers[1]);
                }
                else
                {
                    maior = int.Parse(numbers[1]);
                    menor = int.Parse(numbers[0]);
                }

                for (int j = menor; j <= maior; j++)
                {
                    if (j % 2 != 0)
                        soma += j;
                }
                WriteLine(soma);
            }
            
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
