using System;

namespace laba4_oop_2kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            double func, min, max, c;
        // ввід значень
        metka1: Console.Write("Enter the x value: ");
            double x = double.Parse((Console.ReadLine()));
            Console.Write("Enter the y value: ");
            double y = double.Parse((Console.ReadLine()));
            Console.Write("Enter the z value: ");
            double z = double.Parse((Console.ReadLine()));
            // пошук максимального значення х і у
            if (x > y) max = x;
            else max = y;
            // пошук мінімального значення х і у
            if (x < y + z) min = x;
            else min = y + z;

            c = max - y;
            if (c == 0)
            {
                Console.WriteLine("The denominator is zero");
                goto metka1;
            }
            else func = min / max - y;

            Console.WriteLine($"X={x}, Y={y}, Z={z}\n Result: F = {func}");
            Console.ReadKey();
        }
    }
}
