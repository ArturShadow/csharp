using System;

namespace _07Pinito
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, esp, aste, lActual;
            Console.WriteLine("Que tan lto quieres tu arbol?");
            n = int.Parse(Console.ReadLine());

            for(lActual = 1; lActual <= n; lActual++){
                for(esp = 0; esp < n - lActual; esp++){
                    Console.Write(" ");
                }
                for(aste = 0; aste < (lActual*2)-1; aste++){
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
