using System;

namespace projekt123
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Zaawansowany Kalkulator");
                Console.WriteLine("1. Dodawanie");
                Console.WriteLine("2. Odejmowanie");
                Console.WriteLine("3. Mnożenie");
                Console.WriteLine("4. Dzielenie");
                Console.WriteLine("5. Potęgowanie");
                Console.WriteLine("6. Pierwiastkowanie");
                Console.WriteLine("7. Wyjście");
                Console.Write("Wybierz operację (1-7): ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 7) break;

                Console.Write("Podaj pierwszą liczbę: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                double num2 = 0;
                if (choice != 6)
                {
                    Console.Write("Podaj drugą liczbę: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }

                try
                {
                    double result = Calculate(choice, num1, num2);
                    Console.WriteLine($"Wynik: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Naciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
            }
        }

        public static double Calculate(int choice, double num1, double num2)
        {
            return choice switch
            {
                1 => num1 + num2,
                2 => num1 - num2,
                3 => num1 * num2,
                4 when num2 != 0 => num1 / num2,
                4 => throw new ArgumentException("Nie można dzielić przez zero!"),
                5 => Math.Pow(num1, num2),
                6 when num1 >= 0 => Math.Sqrt(num1),
                6 => throw new ArgumentException("Nie można pierwiastkować liczby ujemnej!"),
                _ => throw new ArgumentException("Nieprawidłowy wybór!"),
            };
        }
    }
}
