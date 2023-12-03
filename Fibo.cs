using System;

class Fibonacci
{
    static int CalculateFibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }

    static void Main()
    {
        Console.WriteLine("Введіть номер числа Фібоначчі: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Номер числа Фібоначчі має бути не менше 0.");
        }
        else
        {
            int result = CalculateFibonacci(n);
            Console.WriteLine($"Число Фібоначчі на позиції {n} дорівнює {result}");
        }
    }
}
