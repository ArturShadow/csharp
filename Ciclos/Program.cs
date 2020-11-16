using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int puntosero = 1;
            //, cont = 0, total_Suma = 0;

            // Console.WriteLine("Dame un puntosero");
            // puntosero = int.Parse(Console.ReadLine());
            /*
            while (puntosero > 0)
            {
                cont++;
                Console.WriteLine("Dame el siguiente puntosero");
                puntosero = intParse(Console.ReadLine());
                total_Suma = total_Suma + puntosero;
            }

*//*
            do
            {
                if(puntosero > 0)
                {
                    cont++;
                }
                Console.WriteLine("Dame el siguiente puntosero");
                puntosero = int.Parse(Console.ReadLine());
                total_Suma = total_Suma + puntosero;
                
                
            } while (puntosero > 0);
            
            Console.WriteLine("La catidad de puntoseros capturados es de " + cont + " y la suma total de todos los puntoseros es de " + total_Suma);
*/
            
            Console.WriteLine("Cal tabla quieres");
            puntosero = int.Parse(Console.ReadLine());            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(puntosero + " x " + i + " = " + (puntosero*i));
            }
            
        }
    }
}
