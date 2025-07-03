namespace Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Write("Podaj pierwszą liczbę całkowitą:");
                if (!int.TryParse(Console.ReadLine(), out int firstNumber))
                {
                    Console.WriteLine("Podana liczba jest niepoprawna.");
                    return;
                }
                Console.Write("Podaj drugą liczbę całkowitą:");
                if (!int.TryParse(Console.ReadLine(), out int secondNumber))
                {
                    Console.WriteLine("Podana liczba jest niepoprawna.");
                    return;
                }


                Console.WriteLine("Napisz jakie działanie chciałbyś wykonać wpisując z możliwych: +, -, *, /");

                if (!char.TryParse(Console.ReadLine(), out char operation))
                {
                    Console.WriteLine("Podany znak jest nieprawidłowy.");
                    return;
                }
                double result;
                switch (operation)
                {
                    case '+':
                        {
                            result = firstNumber + secondNumber;
                            Console.WriteLine($"Suma liczb = {result}");
                            break;
                        }
                    case '-':
                        {
                            result = firstNumber - secondNumber;
                            Console.WriteLine($"Różnica liczb = {result}");
                            break;
                        }
                    case '*':
                        {
                            result = firstNumber * secondNumber;
                            Console.WriteLine($"Iloczyn liczb = {result}");
                            break;
                        }
                    case '/':
                        {
                            if (secondNumber == 0)
                            {
                                Console.WriteLine("Dzielenie przez zero nie jest dozwolone.");
                                return;
                            }
                            result = (double)firstNumber / secondNumber;
                            Console.WriteLine($"Iloraz liczb = {result}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Podany znak jest nieprawidłowy.");
                            return;
                        }
                }

                Console.WriteLine("Czy chcesz wykonać kolejne działanie? T/N");
                var answer = Console.ReadLine();
                if (answer == "T" || answer == "t")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
