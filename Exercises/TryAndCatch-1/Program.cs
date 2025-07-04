using System;


namespace TryAndCatch_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napisz program, który:
1️ Poprosi użytkownika o podanie dwóch liczb całkowitych: dzielnej i dzielnika.
2️ Spróbuje wykonać dzielenie: dzielna / dzielnik.
3️ Jeśli dzielnik to 0 — zgłosi wyjątek za pomocą throw new DivideByZeroException("Dzielenie przez zero jest niedozwolone.");
4️ Złapie wyjątek w catch, wypisze komunikat na konsoli i zapisze błąd do pliku error_log.txt (tak jak wcześniej, z datą i godziną).*/
            try
            {

                int firstNumber, secondNumber;

                Console.WriteLine("Podaj pierwszą liczbę całkowitą: ");
                if (!int.TryParse(Console.ReadLine(), out firstNumber))
                {
                    throw new FormatException("Podana wartość nie jest liczbą całkowitą");

                }


                Console.WriteLine("Podaj drugą liczbę całkowitą: ");
                if (!int.TryParse(Console.ReadLine(), out secondNumber))
                {
                    throw new FormatException("Podana wartość nie jest liczbą całkowitą.");
                }
                else if (secondNumber == 0)
                {
                    throw new DivideByZeroException("Podana wartość musi byc rożna od zera!");
                }


                var result = (double)firstNumber / secondNumber;
                Console.WriteLine($"Wynik dzielenia = {result}");

            }
            catch(FormatException)
            {
                Console.WriteLine("Podana wartość nie jest liczbą całkowitą,");
                File.AppendAllText("error_log.txt", "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]" + "Podana wartość nie jest liczbą całkowitą.\n");
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Podana liczbą musi być roźna od zera!");
                File.AppendAllText("error_log.txt", "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]" + "Podana wartość musi być rożna od zera!\n");
            }

            
        }
    }
}
