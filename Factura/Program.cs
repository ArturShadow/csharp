using System;

namespace Factura
{
    class Program
    {
        static void Main(string[] args)
        {
            int noArticulos = 0, i;
            double subtot = 0;
            Console.WriteLine("Cuantos articulos se van a capturar");
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
                Console.WriteLine("Cantidad       Descripcion   Precio      Subtotal");
            for(i = 0; i < noArticulos; i++){
                Console.WriteLine(" {0}\t\t{1}\t{2}\t{3} ", cantidad[i], descripcion[i], precio[i], subtotal[i]);
            }  
            Console.WriteLine("Subtotal: " + subtot);
            Console.WriteLine("IVA: " + (subtot*.16));
            Console.WriteLine("Total: " + (subtot+(subtot*.16)));
            
                  //cantidad descricpion precio subtotal
                    //   1     chiccle    5      5
 
                         //subtotal 104
                         //iva       17
                         //total     121
            //presentar subtotal iva16 y total
        }
    }
}
