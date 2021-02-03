using System;

namespace rhombus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int top = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int bottom = (top * 2) - 1;

            for (int ver = 1; ver <= bottom; ver++)
            {
                if (ver <= top)
                {
                    for (int horTop = 1; horTop <= (top + (ver - 1)); horTop++)
                    {
                        if (horTop <= (top - ver))
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                else
                {

                    for (int horBottom = bottom; horBottom >= ((ver + 1) - top); horBottom--)
                    {
                        if (horBottom <= ((top + bottom) - ver))
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

    }

}
