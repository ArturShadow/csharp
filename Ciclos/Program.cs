using System;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            //, cont = 0, total_Suma = 0;

            // Console.WriteLine("Dame un numero");
            // numero = int.Parse(Console.ReadLine());
            /*
            while (numero > 0)
            {
                cont++;
                Console.WriteLine("Dame el siguiente numero");
                numero = intParse(Console.ReadLine());
                total_Suma = total_Suma + numero;
            }

*//*
            do
            {
                if(numero > 0)
                {
                    cont++;
                }
                Console.WriteLine("Dame el siguiente numero");
                numero = int.Parse(Console.ReadLine());
                total_Suma = total_Suma + numero;
                
                
            } while (numero > 0);
            
            Console.WriteLine("La catidad de numeros capturados es de " + cont + " y la suma total de todos los numeros es de " + total_Suma);
*/
            
            Console.WriteLine("Cal tabla quieres");
            numero = int.Parse(Console.ReadLine());            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(numero + " x " + i + " = " + (numero*i));
            }
            
        }
    }
}
