using System;

namespace ForAninado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangulo");
            for(int i = 0; i <= 10; i++) {
                for(int j = 0; j < i; j++){
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("Triangulo Invertido");
            for(int i = 10; i >= 1; i--) {
                for(int j = 0; j < i; j++){
                    Console.Write(" *");
                }
                Console.WriteLine("");
            }
        
        }
    }
}
