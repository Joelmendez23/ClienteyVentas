﻿using System;

namespace SS_Pj
{
    class Program
    {
        static void Main(string[] args)
        {
string salida = "";
decimal montoCliente = 0;
decimal numeroCliente = 0;
decimal numeronuevoCliente = 0;
decimal numeronuevoCliente2 = 0;
decimal numeronuevoCliente3 = 0;
decimal montonuevoCliente = 0;
decimal montonuevoCliente2 = 0;
decimal montonuevoCliente3 = 0;
decimal numeroClienteTotal = 0;
decimal montoClienteTotal = 0;
int nuevocliente = 0; //(1.-si, 2.-no);
string Lector = "";

Console.WriteLine("----------------------------------------------------------------------------");
Console.WriteLine("----------Sistema de Caja Seccion 0463 de Programacion Estructurada---------");
Console.WriteLine("--------------------Claudio Brito De Oleo 16-EIIN-1-029----------------------");
Console.WriteLine("----------------------Joel Mendez 16-SIIN-1-107-----------------------------");
Console.WriteLine("");

Console.WriteLine("Digite el monto de la venta:");
Lector = Console.ReadLine();
montoCliente = Convert.ToDecimal(Lector);

Console.WriteLine("Digite el numero de cliente:");
Lector = Console.ReadLine();
numeroCliente = Convert.ToDecimal(Lector);

Console.WriteLine("hay nuevo cliente? Digite 1 para Si o 2 para no:");
Lector = Console.ReadLine();
nuevocliente = Convert.ToInt32 (Lector);

if (nuevocliente == 1)
        {
        Console.WriteLine("Digite el monto del cliente nuevo:");
        Lector = Console.ReadLine();
        montonuevoCliente = Convert.ToDecimal(Lector);
        
        Console.WriteLine("Digite el numero de cliente nuevo:");
        Lector = Console.ReadLine();
        numeronuevoCliente = Convert.ToDecimal(Lector);
         Console.ReadKey();
        }

Console.WriteLine("hay nuevo cliente? Digite 1 para Si o 2 para no:");
Lector = Console.ReadLine();
nuevocliente = Convert.ToInt32 (Lector);

if (nuevocliente == 1)

{
        Console.WriteLine("Digite el monto del cliente nuevo:");
        Lector = Console.ReadLine();
        montonuevoCliente2 = Convert.ToDecimal(Lector);

        Console.WriteLine("Digite el numero de cliente nuevo:");
        Lector = Console.ReadLine();
        numeronuevoCliente2 = Convert.ToDecimal(Lector);

}

Console.WriteLine("hay nuevo cliente? Digite 1 para Si o 2 para no:");
Lector = Console.ReadLine();
nuevocliente = Convert.ToInt32 (Lector);

if (nuevocliente == 2)
{
Console.WriteLine("El numero de clientes en total fue: ");
numeroClienteTotal = numeroCliente + numeronuevoCliente + numeronuevoCliente2 + numeronuevoCliente3;
Console.WriteLine(numeroClienteTotal);

Console.WriteLine("El monto de consumo total fue: ");
montoClienteTotal = montoCliente + montonuevoCliente + montonuevoCliente2 + montonuevoCliente3;
Console.WriteLine(montoClienteTotal);
Console.ReadKey();

}



}



        }

    }


