using System.Numerics;

namespace Task_Silnia
{
    internal class Program
    {

        /*
Zadanie bazowe: Obliczanie silni
Opis:
Napisz konsolową aplikację w C#, która:

Pyta użytkownika o nieujemną liczbę całkowitą 
𝑁

Sprawdza, czy N≥0. Jeśli nie, wypisuje komunikat o błędnym wejściu i kończy działanie.

Oblicza silnię N! przy pomocy pętli (np. for lub while).

Wyświetla wynik w konsoli.

        */
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nieujemną liczbę całkowitą");

            if(!ulong.TryParse(Console.ReadLine(), out ulong number))
            {
                Console.WriteLine("Podana wartość jest nieprawidłowa!");
                return;
            }

            if (number < 0)
            {
                Console.WriteLine("Podana liczba jest ujemna!");
                return;
            }

            Console.WriteLine("Wybierz opcję obliczania silni:");
            Console.WriteLine("1. Iteracyjnie");
            Console.WriteLine("2. Rekurencyjnie");
            Console.WriteLine("Podaj swój wybór: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    {

                        FunkcjaIteracyjna(number);
                        Console.WriteLine($"Silnia z liczby {number} wynosi: {FunkcjaIteracyjna(number)}");
                        

                        break;
                    }
                case "2":
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Nieznana opcja!");
                        return;
                    }
            }
        }

        static BigInteger FunkcjaIteracyjna(ulong number)
        {
            BigInteger result = 1;
            for (ulong i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }


    }
}
