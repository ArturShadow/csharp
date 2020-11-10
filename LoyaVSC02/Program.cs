//Luis Arturo Loya Baca
//TID11D
using System;

namespace LoyaVSC02
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = "si";
            int op_articulo, op_metodo;
            double descuento = 0, costo = 0, total = 0, porcen = .2;
            
            Console.WriteLine("Bienvenido a La lavandería Master Cleaner");

            while(res == "si" || res == "s")
            {
                Console.WriteLine("Eliga la ropa que desea que lavemos del siguiente menu");
                Console.WriteLine("╔═════════════╦════════════════╦════════════════╗");
                Console.WriteLine("║   Articulo  ║ Lavado en seco ║ Lavado en agua ║");
                Console.WriteLine("╠═════════════╬════════════════╬════════════════╣");
                Console.WriteLine("║   1.Blusas  ║      $50.00    ║     $20.00     ║");
                Console.WriteLine("╠═════════════╬════════════════╬════════════════╣");
                Console.WriteLine("║   2.Faldas  ║      $55.00    ║     $25.00     ║");
                Console.WriteLine("╠═════════════╬════════════════╬════════════════╣");
                Console.WriteLine("║3. Pantalones║      $60.00    ║     $30.00     ║");
                Console.WriteLine("╠═════════════╬════════════════╬════════════════╣");
                Console.WriteLine("║ 4.Chamarras ║      $70.00    ║     $40.00     ║");
                Console.WriteLine("╠═════════════╬════════════════╬════════════════╣");
                Console.WriteLine("║  5. Sacos   ║      $80.00    ║     $45.00     ║");
                Console.WriteLine("╚═════════════╩════════════════╩════════════════╝");
                do
                {
                    op_articulo = int.Parse(Console.ReadLine());
                    if(op_articulo > 5)
                    {
                        System.Console.WriteLine("No tenemos esa opcion en el menu, vuelva a intentarlo");
                    }
                } while (op_articulo > 5);
                Console.WriteLine("");
                Console.WriteLine("");

                switch (op_articulo)
                {
                    case 1:
                        Console.WriteLine("A continuacion escoga el metodo de lavado");
                        Console.WriteLine("1. Lavado en seco");
                        Console.WriteLine("2. Lavado en agua");
                        do
                        {
                            op_metodo = int.Parse(Console.ReadLine());
                            if (op_metodo > 2)
                            {
                                System.Console.WriteLine("No tenemos un metodo con esa opcion, vuelva a intentarlo");
                            }
                        } while (op_metodo > 2);

                        switch (op_metodo)
                        {
                            case 1:
                                Console.WriteLine("Se ha seleccionado Blusas en lavado en seco");
                                costo = 50.00;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                Console.WriteLine("el total a pagar es de $" + costo);
                                break;

                            case 2:
                                Console.WriteLine("Se ha seleccionado Blusas en lavado en agua");
                                costo = 25;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                total = costo - descuento;
                                Console.WriteLine("el total a pagar es de $" + costo);
                                break;
                        }

                        break;

                    case 2:
                        Console.WriteLine("A continuacion escoga el metodo de lavado");
                        Console.WriteLine("1. Lavado en seco");
                        Console.WriteLine("2. Lavado en agua");
                        do
                        {
                            op_metodo = int.Parse(Console.ReadLine());
                            if(op_metodo > 2)
                            {
                                System.Console.WriteLine("No tenemos un metodo con esa opcion, vuelva a intentarlo");
                            }
                        } while (op_metodo > 2 );

                        switch (op_metodo)
                        {
                            case 1:
                                Console.WriteLine("Se ha seleccionado Faldas en lavado en seco");
                                costo = 55;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                Console.WriteLine("el total a pagar es de $" + costo);
                                break;

                            case 2:
                                Console.WriteLine("Se ha seleccionado Faldas en lavado en agua");
                                costo = 25;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                Console.WriteLine("el total a pagar es de $" + costo);
                                break;
                        }

                        break;
                    case 3:
                        Console.WriteLine("A continuacion escoga el metodo de lavado");
                        Console.WriteLine("1. Lavado en seco");
                        Console.WriteLine("2. Lavado en agua");
                        do
                        {
                            op_metodo = int.Parse(Console.ReadLine());
                            if (op_metodo > 2)
                            {
                                System.Console.WriteLine("No tenemos un metodo con esa opcion, vuelva a intentarlo");
                            }
                        } while (op_metodo > 2);

                        switch (op_metodo)
                        {
                            case 1:
                                Console.WriteLine("Se ha seleccionado Pantalones en lavado en seco");
                                costo = 60;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                Console.WriteLine("el total a pagar es de $" + costo);
                                break;

                            case 2:
                                Console.WriteLine("Se ha seleccionado Pantalones en lavado en agua");
                                costo = 30;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                break;
                        }

                        break;
                    case 4:
                        Console.WriteLine("A continuacion escoga el metodo de lavado");
                        Console.WriteLine("1. Lavado en seco");
                        Console.WriteLine("2. Lavado en agua");
                        do
                        {
                            op_metodo = int.Parse(Console.ReadLine());
                            if (op_metodo > 2)
                            {
                                System.Console.WriteLine("No tenemos un metodo con esa opcion, vuelva a intentarlo");
                            }
                        } while (op_metodo > 2);

                        switch (op_metodo)
                        {
                            case 1:
                                Console.WriteLine("Se ha seleccionado Chamarras en lavado en seco");
                                costo = 70;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                Console.WriteLine("el total a pagar es de $" + costo);
                                break;

                            case 2:
                                Console.WriteLine("Se ha seleccionado Chamarras en lavado en agua");
                                costo = 40;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                Console.WriteLine("el total a pagar es de $" + costo);
                                break;
                        }

                        break;
                    case 5:
                        Console.WriteLine("A continuacion escoga el metodo de lavado");
                        Console.WriteLine("1. Lavado en seco");
                        Console.WriteLine("2. Lavado en agua");
                        do
                        {
                            op_metodo = int.Parse(Console.ReadLine());
                            if (op_metodo > 2)
                            {
                                System.Console.WriteLine("No tenemos un metodo con esa opcion, vuelva a intentarlo");
                            }
                        } while (op_metodo > 2);

                        switch (op_metodo)
                        {
                            case 1:
                                Console.WriteLine("Se ha seleccionado Sacos en lavado en seco");
                                costo = 80;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                Console.WriteLine("el total a pagar es de $" + costo);
                                break;

                            case 2:
                                Console.WriteLine("Se ha seleccionado Sacos en lavado en agua");
                                costo = 45;
                                descuento = costo * porcen;
                                total = costo - descuento;
                                Console.WriteLine("el total a pagar es de $" + costo);
                                break;
                        }
                        break;

                }
                Console.WriteLine("Y tenemos un descuento en esas prendas del 20%, total a pagar es $" + total);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Tiene mas ropa?");
                res = Console.ReadLine().ToLower();
            }
        }
    }
}
