﻿using System;
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
            int A = 0;
            int N = 0;
            A = int.Parse(ReadLine());
            //entender esta questão e resolver!
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