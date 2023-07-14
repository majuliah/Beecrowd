using static System.Console;

namespace Exercice1075
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice1075
            Exercice1075();
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
    }
}
