
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace modulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            int check;
            do
            {
                Console.Write("Podaj liczbę całkowitą: ");
                input = Console.ReadLine();
            }
            while (!CheckINT(input, out number));
           
            check = number % 2;

            if (check == 0) 
            {
                Console.WriteLine($"\n Wprowadzona liczba: {number}, jest parzysta");
            }
            else
            {
                Console.WriteLine($"\n Wprowadzona liczba: {number}, jest nieparzysta");
            }
        }

        static bool CheckINT(string input, out int result)
        {
            return int.TryParse(input, out result);
        }
    }
}
