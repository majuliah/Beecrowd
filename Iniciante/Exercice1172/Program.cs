using System;
using static System.Console;
using System.Globalization;

namespace Exercice1172
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercice1172
            //Exercice1172();            
            
            //Exercice1173
            //Exercice1173();
            
            //Exercice1174
            Exercice1174();
        }

        static void Exercice1174()
        {
            double[] vetorNumeros = new double[100];
            double numeros;

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                numeros = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
                vetorNumeros[i] = numeros;
            }

            for (int i = 0; i < vetorNumeros.Length; i++)
            {
                if (vetorNumeros[i] <= 10)
                    WriteLine($"A[{i}] = {vetorNumeros[i].ToString("F1", CultureInfo.InvariantCulture)}");
            }

        }
        static void Exercice1173()
        {
            int[] vetorDobro = new int[10];
            int numeroInicial = int.Parse(ReadLine());

            for (int i = 0; i < vetorDobro.Length; i++)
            {
                vetorDobro[i] = numeroInicial;
                numeroInicial *= 2;
            }

            for (int i = 0; i < vetorDobro.Length; i++)
                WriteLine($"N[{i}] = {vetorDobro[i]}");
        }

        static void Exercice1172()
        {
            int[] vetor = new int[10];
            int numero = 0;

            for (int i = 0; i < vetor.Length; i++)
            {
                numero = int.Parse(ReadLine());
                if (numero <= 0)
                    vetor[i] = 1;
                else
                    vetor[i] = numero;
            }

            for (int i = 0; i < vetor.Length; i++)
                WriteLine($"X[{i}] = {vetor[i]}");            
        }
    }
}
