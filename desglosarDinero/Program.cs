//Luis Arturo Loya Baca
//TID11D
using System;

namespace desglosaDinero
{
    class Program
    {
        static void Main(string[] args)
        {

            string res = "si";
            int aux = 0, dinero = 0;
            int billetes500 = 0, billetes100 = 0, billetes200 = 0, billetes50 = 0,  billetes20 = 0, monedas10 = 0, monedas5 = 0, monedas2 = 0, monedas1 = 0;

            while(res == "s" || res == "si"){

                Console.WriteLine("Dame una cifra menor a 1000");
                do{
                    dinero = int.Parse(Console.ReadLine());
                    if(dinero > 1000){
                        Console.WriteLine("Solo se admiten cifras menores o iguales a 1000");
                    }
                    Console.WriteLine("$" + dinero + " pesos desglosado seria ");

                } while(dinero > 1000);
                aux = dinero;

                if(aux >= 500) {    
                    billetes500 = aux/500;
                    aux = aux % 500;
                    Console.WriteLine(billetes500 + "  billetes de 500.");
                }

                if(aux < 500 && aux >= 200) {
                    billetes200 = aux/200;
                    aux = aux % 200;
                    Console.WriteLine(billetes200 + " billetes de 200.");
                }
                if(aux < 200 && aux >= 100) {
                    billetes100 = aux/100;
                    aux = aux % 100;
                    Console.WriteLine(billetes100 + " billetes de 100.");
                }
                    
                if(aux < 100 && aux >= 50) {
                    billetes50 = aux/50;
                    aux = aux % 50;
                    Console.WriteLine(billetes50 + " billetes de 50.");
                }
                    
                if(aux < 50 && aux >= 20) {
                    billetes20 = aux/20;
                    aux = aux % 20;
                    Console.WriteLine(billetes20 + " billetes de 20.");
                }
                    
                if(aux < 20 && aux >= 10) {
                    monedas10 = aux/10;
                    aux = aux % 10;
                    Console.WriteLine(monedas10 + " monedas de 10" + monedas10);
                }
                    
                if(aux < 10 && aux >= 5) {
                    monedas5 = aux/5;
                    aux = aux % 5;
                    Console.WriteLine(monedas5 + " monedas de 5");
                }
                if(aux < 5 && aux >= 2) {
                    monedas2 = aux/2;
                    aux = aux % 2;
                    Console.WriteLine(monedas2 + " monedas de 2");
                }
                if(aux < 2 && aux >= 1) {
                    monedas1 = aux/1;
                    aux = aux % 5;
                    Console.WriteLine(monedas1 + " monedas de 1");
                }
                Console.WriteLine("Quieres otra cantidad?");
                res = Console.ReadLine().ToLower(); //SI -> si
            }
        } 
    }
}
