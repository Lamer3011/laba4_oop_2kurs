using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            float x, y;
            Console.Write("X: ");
            x = float.Parse((Console.ReadLine()));
            Console.Write("Y: ");
            y = float.Parse((Console.ReadLine()));
            if (y < 0)
            {
                if (y + x * x < 2)
                {
                    if (x >= 0) N = 2;
                    else N = 1;
                }
                else
                {
                    if (x >= 0) N = 4;
                    else N = 3;
                }
            }
            else
            {
                if (x >= 0) N = 3;
                else N = 2;
            }
            Console.WriteLine($"Result: \nPoint M({x}, {y}) Lies in the area with N = {N}");
            Console.ReadKey();
        }

    }
}
