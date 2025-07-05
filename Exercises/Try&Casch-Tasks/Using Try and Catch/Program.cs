using System;

namespace Using_Try_and_Catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę całkowitą:");
            int firstNumber;
            try
            {
                firstNumber = int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine($"Niepoprawny format liczby!");
                return;
            }

            try
            {
                double result = 100.0 / firstNumber;
                Console.WriteLine($"100 : {firstNumber} = {result}");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Nie można dzielić przez zero!");
                return;
            }
        }
    }
}
