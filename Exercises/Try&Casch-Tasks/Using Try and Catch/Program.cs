using System;

namespace Using_Try_and_Catch
{
    internal class Program
    {

        /*
         Napisz program w C#, który:

Poprosi użytkownika o podanie liczby całkowitej (jako tekst).

W bloku try wykona wyłącznie konwersję tego tekstu na typ int (obsłuż potencjalny FormatException).

Jeżeli parsowanie się nie powiedzie, program powinien wypisać komunikat o błędnym formacie i zakończyć działanie.

Poza blokiem parsowania, w odrębnym bloku try, podzieli stałą wartość 100 przez wczytaną liczbę (obsłuż potencjalny DivideByZeroException).

W odpowiednich blokach catch wypisze:

w przypadku FormatException – „Niepoprawny format liczby!”,

w przypadku DivideByZeroException – „Nie można dzielić przez zero!”.

Dodatkowe wskazówki:

Upewnij się, że każdy try obejmuje tylko tę część kodu, która może wygenerować dany wyjątek.

Po złapaniu FormatException natychmiast zakończ program (np. przez return w Main).

Drugi blok try powinien dotyczyć wyłącznie operacji dzielenia i jej obsługi.
        */


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
