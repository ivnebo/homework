using System;

namespace Calculator
{
    class Program
    {
        static long plus(long a, long b)
        {
            long result = a + b;
            return result;
        }

        static long minus(long a, long b)
        {
            long result = a - b;
            return result;
        }

        static long multiply(long a, long b)
        {
            long result = a * b;
            return result;
        }

        static long share(long a, long b)
        {
            long result = a / b;
            return result;
        }

        static long calculator(long a, long b, string _operator)
        {
            long result = 0;
            switch (_operator)
            {
                case "+":
                    result = plus(a, b);
                    break;
                case "-":
                    result = minus(a, b);
                    break;
                case "*":
                    result = multiply(a, b);
                    break;
                case "/":
                    result = share(a, b);
                    break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите первое число : ");
                long a = long.Parse(Console.ReadLine());
                Console.Write("Введите второе число : ");
                long b = long.Parse(Console.ReadLine());
                Console.Write("Введите символ '+' '-' '*' '/' : ");
                string _operator = Console.ReadLine();

                long result = calculator(a, b, _operator);
                Console.Write("Результат : ");
                Console.WriteLine(result);
            }
        }
    }
}
