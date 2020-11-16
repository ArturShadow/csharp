using System;

namespace _01ListDefin
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio, tope;
            Console.WriteLine("Cual es el primer nuumero");
            inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Cual es el segundo numero");
            tope = int.Parse(Console.ReadLine());

            Console.WriteLine("Los numeros que estan en ese rango son:");
            for(int i = inicio; i <= tope; i++){
                Console.Write(i);
                if(i == tope){
                    Console.Write(".");
                } else {
                    Console.Write(", ");
                }
            }
        }
    }
}
