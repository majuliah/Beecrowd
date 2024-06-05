using System;
using System.Globalization;
using static System.Console;

namespace Exercice1145
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice1145
            //Exercice1145();

            //Exercice1146
            //Exercice1146();

            //Exercice1149
            //Exercice1149();

            //Exercice1153
            //Exercice1153();

            //Exercice1151
            //Exercice1151();

            //Exercice1150
            //Exercice1150();

            //Exercice1154
            //Exercice1154();

            //Exercice1155
            //Exercice1155();

            //Exercice1156
            //Exercice1156();

            //Exercice1157
            //Exercice1157();

            //Exercice1158
            //Exercice1158();

            //Exercice1159
            // Exercice1159();

            //Exercice1160
            // Exercice1160();
            
            //Exercice1164
            //Exercice1164();            
            
            //Exercice1165
            //Exercice1165();
        }

        static void Exercice1165()
        {
            int numero = 0;
            int totalNumeros = 0;
            int testes = int.Parse(ReadLine());

            for (int i = 0; i < testes; i++)
            {
                totalNumeros = 0;
                numero = int.Parse(ReadLine());
                
                for(int j = 1; j <= numero; j++)
                {
                    if (numero % j == 0)
                        totalNumeros++;
                }
                
                if (numero == 2 || totalNumeros == 2) 
                    WriteLine($"{numero} eh primo");
                else
                    WriteLine($"{numero} nao eh primo");
            }
        }            
        
        static void Exercice1164()
        {
            int testes = int.Parse(ReadLine());
            int numero = 0;
            int soma = 0;

            for (int i = 0; i < testes; i++)
            {
                soma = 0;
                numero = int.Parse(ReadLine());

                for (int j = 1; j < numero; j++)
                {
                    if (numero % j == 0)
                        soma += j;
                }

                if (soma == numero)
                    WriteLine($"{numero} eh perfeito");
                else
                    WriteLine($"{numero} nao eh perfeito");
            }
        }            
        
        static void Exercice1160()
        {
            WriteLine("Do it tomorrow");
        }            
        static void Exercice1159()
        {
            
            int soma = 0;
            int contador = 0;
            int totalPar = 0;

            int saida = int.Parse(ReadLine());
            if (saida != 0) 
            {
                do
                {
                    do
                    {
                        if ((saida + contador) % 2 == 0)
                        {
                            soma += saida + contador;
                            totalPar++;
                        }
                        contador++;

                    } while (totalPar < 5);

                    WriteLine(soma);
                    contador = 0;
                    totalPar = 0;
                    soma = 0;
                    saida = int.Parse(ReadLine());
                } while (saida != 0);
            }
            
        }        
        static void Exercice1158()
        {
            WriteLine("Entre com o número de testes");
            int testes = int.Parse(ReadLine());

            string[] vetorNums;
            int totalImpar = 0;

            int soma = 0;
            int cont = 0;

            for (int i = 0; i < testes; i++)
            {
                vetorNums = ReadLine().Split(' ');
                int x = int.Parse(vetorNums[0]);
                int y = int.Parse(vetorNums[1]);
                
                do
                {
                    if ((x + cont) % 2 != 0)
                    {
                        soma += (x + cont);
                        totalImpar++;
                    }
                    cont++;

                } while (totalImpar < y);
                WriteLine(soma);

                soma = 0; totalImpar = 0; cont = 0;
            }
        }
        static void Exercice1157()
        {
            WriteLine("Entre com um número");
            int numero = int.Parse(ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                    WriteLine(i);
            }
        }
        static void Exercice1156()
        {
            double numerador = 3.0;
            double denominador = 2.0;
            double soma = 1.0;
            double calculo = 0.0;

            while (numerador <= 39)
            {
                calculo = (numerador / denominador);
                soma = soma + calculo;
                numerador += 2.0;
                denominador *= 2.0;
                calculo = 0.0;
            }

            WriteLine($"Soma = " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
        static void Exercice1155()
        {
            double S = 1.0;
            for (int i = 2; i <= 100; i++)
            {
                S += 1.0 / i;
            }
            WriteLine($"{S.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        static void Exercice1154()
        {
            double media;
            int quantidade = 0;
            double idade = 0.0;
            int idades = 0;

            while (idades >= 0)
            {
                idades = int.Parse(ReadLine());
                if (idades >= 0)
                {
                    idade += idades;
                    quantidade++;
                }
            }

            media = idade / (double)quantidade;
            WriteLine($"{media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        static void Exercice1150()
        {
            int x = int.Parse(ReadLine());
            int z = 0;
            int soma = x;

            while (z < x)
                z = int.Parse(ReadLine());

            for (int i = x; i < z; i++)
            {
                soma++;
            }
            WriteLine(soma);

        }
        static void Exercice1151()
        {
            int number = 0;
            int a = 0;
            int b = 1;
            
            do
            {
                number = int.Parse(ReadLine());
                
            } while (number <= 0 || number > 46);

            for (int i = 0; i < number; i++)
            {
                if (i == number - 1)
                    WriteLine(a);
                else
                    Write($"{a} ");
                
                int aux = b;
                b = a;
                a = b + aux;
            }
        }
        static void Exercice1153()
        {
            int fatorial = 0;
            int numero = int.Parse(ReadLine());

            for (int i = 1; i <= numero; i++)
                fatorial += numero * (numero - i);
            
            WriteLine(fatorial);
        }
        static void Exercice1149()
        {
            int contador = 1;
            int soma = 0;
            string[] numeros = ReadLine().Split(' ');
            int a = int.Parse(numeros[0]);
            int n = int.Parse(numeros[contador]);

            while (n <= 0)
            {
                contador++;
                n = int.Parse(numeros[contador]);
            }

            for (int i = 0; i < n; i++)
            {
                soma += a + contador;
            }
            WriteLine(soma);
        }
        static void Exercice1146()
        {
            int numero = 1;
            do
            {
                numero = int.Parse(ReadLine());
                for (int i = 1; i <= numero; i++)
                    Write($"{i} ");
                WriteLine();
            } while (numero != 0);
        }
        static void Exercice1145()
        {
            string[] numeros = ReadLine().Split(' ');
            int numerosPorLinha = int.Parse(numeros[0]);
            int final = int.Parse(numeros[1]);
            int contador = 1;

            do
            {
                for (int i = 1; i <= numerosPorLinha; i++)
                {
                    Write($"{contador} ");
                    contador++;
                }
                WriteLine();
            } while (contador <= final);
        }
    }
}