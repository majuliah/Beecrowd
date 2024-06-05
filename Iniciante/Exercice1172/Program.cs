using System;
using static System.Console;

namespace Exercice1172
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercice1172
            //Exercice1172();            
            
            //Exercice1173
            Exercice1173();
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
