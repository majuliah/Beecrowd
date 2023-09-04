using System;
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