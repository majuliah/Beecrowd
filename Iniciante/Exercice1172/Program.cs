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
            //Exercice1174();

            //Exercice1175
            //Exercice1175();            

            //Exercice1180
            //Exercice1180();

            //Exercice1177
            Exercice1177();
        }


        static void Exercice1177()
        {
            int entrada = 0;
            do
            {
                entrada = int.Parse(ReadLine());
            } while (entrada < 2 || entrada > 50);

            int[] vetorValores = new int[entrada];
            for (int i = 0; i < vetorValores.Length; i++)
                vetorValores[i] = i;            
            

            int[] vetorSequencia = new int[1000];
            int contador = 0;
            for (int i = 0; i < vetorSequencia.Length; i = contador)
            {
                for (int j = 0; j < entrada; j++)
                {
                    if (contador < vetorSequencia.Length) 
                    {
                        vetorSequencia[contador] = vetorValores[j];
                        contador++;
                    }
                }
            }

            for (int i = 0; i < vetorSequencia.Length; i++)
                WriteLine($"N[{i}] = {vetorSequencia[i]}");           
        }
        static void Exercice1180()
        {
            int tamanhoVetor = int.Parse(ReadLine());
            int[] vetorMenorNum = new int[tamanhoVetor];
            string numeros = ReadLine();

            for (int i = 0; i < vetorMenorNum.Length; i++)
                vetorMenorNum[i] = int.Parse(numeros.Split(' ')[i]);

            int menorValor = 0;
            int posicaoMenor = 0;

            menorValor = vetorMenorNum[0];
            for (int i = 0; i < vetorMenorNum.Length; i++)
            {
                if (vetorMenorNum[i] <= menorValor)
                {
                    menorValor = vetorMenorNum[i];
                    posicaoMenor = i;
                }
            }

            WriteLine($"Menor valor: {menorValor}");
            WriteLine($"Posicao: {posicaoMenor}");
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
