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

            if(number < 0)
            {
                Console.WriteLine("Podana liczba jest ujemna!");
                return;
            }
            ulong silnia = 1;
            for(ulong i = 1; i <= number; i++)
            {
                silnia *= i;
            }
            Console.WriteLine($"Silnia dla {number} wynosi {silnia}!");
        }
    }
}
