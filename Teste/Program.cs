using System;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leia um valor inteiro N. Apresente " +
                "o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.");

            int numero = int.Parse(Console.ReadLine());

            if(numero <= 1)
                Console.WriteLine("Não é possível calcular números menores que 1");
            else
            {
                for(int i = 1; i <= numero; i++)
                {
                    if(i % 2 == 0)
                    {
                        Console.WriteLine($"{i} ^ 2 = {Math.Pow(i, 2)}");
                    }
                }
            }
        
        }
    }
}
