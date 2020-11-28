//Luis Arturo Loya Baca
//TID11D
using System;

namespace Factura
{
    class Program
    {
        static void Main(string[] args)
        {
            int noArticulos = 0, i;
            double subtot = 0;
            Console.Write("¿Cuantos articulos se van a capturar? ");
            noArticulos = int.Parse(Console.ReadLine());
            int[] cantidad = new int[noArticulos];
            string[] descripcion = new string[noArticulos];
            double[] subtotal = new double[noArticulos];
            double[] precio = new double[noArticulos];
            
            for (i = 0; i < noArticulos; i++)
            {
                Console.Write("Descripcion: ");
                descripcion[i] = Console.ReadLine();

                Console.Write("Cantidad: ");
                cantidad[i] = int.Parse(Console.ReadLine());
                Console.Write("Precio: ");
                precio[i] = double.Parse(Console.ReadLine());
                
                subtotal[i] = cantidad[i] * precio[i];
                subtot = subtot + subtotal[i];
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Cantidad\tDescripcion\tPrecio\tSubtotal");
            Console.WriteLine("=========================================================");
            for(i = 0; i < noArticulos; i++){
                Console.WriteLine("{0:D4}\t\t  {1}\t\t{2:C2}\t{3:C2} ", cantidad[i], descripcion[i], precio[i], subtotal[i]);
            }  
            Console.WriteLine("=========================================================");
            Console.WriteLine("\t\t\tSubtotal: \t{0:C1} ", subtot);
            Console.WriteLine("\t\t\tIVA: \t\t{0:C1}", (subtot*.16));
            Console.WriteLine("\t\t\tTotal: \t\t{0:C1}", subtot+(subtot*.16));
            Console.WriteLine("=========================================================");
        }
    }
}
