using System;

namespace _06TriangAster
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Que tan alto quieres el triangulo de ateriscos");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i <= n; i++) {
                for(int j = 0; j < i; j++){
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
        }
    }
}
