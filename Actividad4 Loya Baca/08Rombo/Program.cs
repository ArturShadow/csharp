//Luis Arturo Loya Baca
using System;

namespace _08Rombo
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;
            Console.WriteLine("¿Que tan alto quieres el rombo? (parte superior) ");
            n = int.Parse(Console.ReadLine());
 
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
 
            for (i = n - 1; i >= 1; i--)
            {
                for (j = 1; j <= n - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

        }
    }
}
