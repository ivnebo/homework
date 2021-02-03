using System;

namespace Pifagor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите начальное вертикальное число : ");
            int verticalStart = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное вертикальное число : ");
            int verticalEnd = int.Parse(Console.ReadLine());
            Console.Write("Введите начальное горизонтальное число : ");
            int horisontalStart = int.Parse(Console.ReadLine());
            Console.Write("Введите конечное горизонтальное число : ");
            int horisontalEnd = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int sum = verticalEnd * horisontalEnd;
            int length = sum;
            int spase = 0;
            for (; length >= 1; spase++)
            {
                length = length / 10;
            }

            for (int indent = 0; indent <= spase; indent++)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            for (int head = horisontalStart; head <= horisontalEnd; head++)
            {
                    int number = head;
                    int place = 0;
                    for (; number >= 1; place++)
                    {
                        number = number / 10;
                    }
                    for (int indent = 0; indent <= spase - place; indent++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(head);
            }
            Console.WriteLine();

            for (int indent = 0; indent <= spase; indent++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            for (int line = horisontalStart; line <= horisontalEnd; line++)
            {
                    for (int indent = 0; indent <= spase; indent++)
                    {
                        Console.Write("-");
                    }
            }
            Console.WriteLine();

            for (int verticalBody = verticalStart; verticalBody <= verticalEnd; verticalBody++)
            {
                int number = verticalBody;
                int place = 0;
                for (; number >= 1; place++)
                {
                    number = number / 10;
                }
                for (int indent = 0; indent <= spase - place; indent++)
                {
                    Console.Write(" ");
                }
                Console.Write(verticalBody + "|");

                for (int horisontalBody = horisontalStart; horisontalBody <= horisontalEnd; horisontalBody++)
                {

                    number = verticalBody * horisontalBody;
                    place = 0;
                    for (; number >= 1; place++)
                    {
                        number = number / 10;
                    }
                    for (int indent = 0; indent <= spase - place; indent++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(verticalBody * horisontalBody);
                }
             Console.WriteLine();
            }

        }
    }
}
