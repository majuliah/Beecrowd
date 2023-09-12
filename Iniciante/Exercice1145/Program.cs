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
            
            //Exercice1157
            //Exercice1157();
            
            //Exercice1158
            //Exercice1158();
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