using System;



namespace UseTryAndCatch
{

    /*
 🔹 Napisz program konsolowy, który:
1️ Poprosi użytkownika o wpisanie liczby całkowitej. -> OK
2️ Spróbuje sparsować wpisaną wartość do int. -> OK
3️ Jeśli wpis jest niepoprawny (np. litery zamiast liczby) — zgłosi wyjątek przy użyciu throw new FormatException.
4️ Złapie wyjątek w catch, wypisze komunikat na konsoli i zapisze błąd do pliku error_log.txt.*/
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz liczbę całkowitą:");
            
            try
            {
                if(int.TryParse(Console.ReadLine(), out int numberInt) == false) // sprawdzamy co zwraca int.TryParse
                {
                    throw new FormatException();// wyrzuca wyjatek
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Podana wartość nie jest liczbą całkowitą.");
                File.AppendAllText("error_log.txt", "[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "]" + "Podana wartość nie jest liczbą całkowitą.\n");
                return;
            }
            

        }
    }
}


