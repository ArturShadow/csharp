//Luis Arturo Loya Baca
//TID11D
using System;

namespace LoyaVSC01
{
    class Program
    {
        static void Main(string[] args)
        {

            String nombre = "", res = "si";
            int op_tipoCliente;
            double precioPorCaseton, descuento = 0, total = 0, totalAPagar = 0, casetonesComprados = 0;

            while ((res == "si" || res == "s"))
            {
                Console.WriteLine("Cual es el nombre del cliente?");
                nombre = Console.ReadLine();

                Console.WriteLine("Cuiantos casetones compro?");
                casetonesComprados = double.Parse(Console.ReadLine());

                Console.WriteLine("Cuianto cuesta cada caseton?");
                precioPorCaseton = double.Parse(Console.ReadLine());

                total = casetonesComprados * precioPorCaseton;

                do
                {
                    Console.WriteLine("Cual es su tipo?");
                    op_tipoCliente = int.Parse(Console.ReadLine());
                    if (op_tipoCliente > 4)
                    {
                        System.Console.WriteLine("      ");
                        Console.WriteLine("La respuesta debe estar entre 1 y 4");
                        Console.WriteLine("Intente de nuevo");
                    }

                } while (op_tipoCliente > 4);

                switch (op_tipoCliente)
                {
                    case 1:
                        Console.WriteLine("Se aplicara un descuento de 5%");
                        descuento = (total * .05);
                        break;

                    case 2:
                        Console.WriteLine("se aplicar un descuento de 8%");
                        descuento = (total * .08);

                        break;

                    case 3:
                        Console.WriteLine("Se aplicaras un descuento de 12%");
                        descuento = (total * .12);
                        break;

                    case 4:
                        Console.WriteLine("Se apli8care un descuento de 15%");
                        descuento = (total * .15);
                        break;

                }
                totalAPagar = total - descuento;
                Console.WriteLine("El total a pagar del cliente " + nombre + " es de $" + total + " y con el descuento aplicado es de $" + totalAPagar);

                Console.WriteLine("Hsy otro cliente?");
                res = Console.ReadLine().ToLower();

            }
        }
    }
}
