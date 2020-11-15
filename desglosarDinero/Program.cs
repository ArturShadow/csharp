using System;

namespace desglosaDinero
{
    class Program
    {
        static void Main(string[] args)
        {

            string res = "si";
            int aux = 0, dinero = 0;
            int billetes500 = 0, billetes100 = 0, billetes50 = 0,  billetes20 = 0, monedas10 = 0, monedas5 = 0;

            while(res == "s" || res == "si"){

                Console.WriteLine("Dame una cifra menor a 1000");
                do{
                dinero = int.Parse(Console.ReadLine());
                aux = dinero;

                } while(aux > 1000);

                if(aux >= 500) {
                    billetes500 = aux/500;
                    aux = aux % 500;
                    Console.WriteLine(dinero + " en billetes de 500 son " + billetes500);
                }

                if(aux < 500 && aux >= 100) {
                    billetes100 = aux/100;
                    aux = aux % 100;
                    Console.WriteLine(dinero + " en billetes de 100 son " + billetes100);
                }
                    
                if(aux < 100 && aux >= 50) {
                    billetes50 = aux/50;
                    aux = aux % 50;
                    Console.WriteLine(dinero + " en billetes de 50 son " + billetes50);
                }
                    
                if(aux < 50 && aux >= 20) {
                    billetes20 = aux/20;
                    aux = aux % 20;
                    Console.WriteLine(dinero + " en billetes de 20 son " + billetes20);
                }
                    
                if(aux < 20 && aux >= 10) {
                    monedas10 = aux/10;
                    aux = aux % 10;
                    Console.WriteLine(dinero + " en monedas de 10 son " + monedas10);
                }
                    
                if(aux < 10 && aux >= 5) {
                    monedas5 = aux/5;
                    aux = aux % 5;
                    Console.WriteLine(dinero + " en monedas de 5 son " + monedas5);
                }
                Console.WriteLine("Quieres otra aux?");
                res = Console.ReadLine().ToLower();
            }
        } 
    }
}
