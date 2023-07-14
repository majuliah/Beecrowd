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
    }
}
