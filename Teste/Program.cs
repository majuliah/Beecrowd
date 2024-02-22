using System;
using System.Globalization;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercício teste
            // ExercicioTeste();
            SegundoExercicio();
        }
        public static void ExercicioTeste()
        {
            Console.WriteLine("Leia um valor inteiro N. Apresente " +
                "o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.");

            int numero = int.Parse(Console.ReadLine());

            if (numero <= 1)
                Console.WriteLine("Não é possível calcular números menores que 1");
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} ^ 2 = {Math.Pow(i, 2)}");
                    }
                    Console.Write("Exercício concluído!");
                }
            }
        }
        
        public static void SegundoExercicio()
        {
            Console.WriteLine("Entre com a primeira nota");
            double nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com a segunda nota");
            double nota2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com a terceira nota");
            double nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (nota1 + nota2 + nota3) / 3.0;
            Console.WriteLine($"MEDIA = {media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
