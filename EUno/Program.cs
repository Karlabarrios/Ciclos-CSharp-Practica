﻿using System;

namespace EUno
{
    class Program
    {
        static void Main(string[] args)
        {
            //PROGRAMA CON "F O R"
            //Console.WriteLine("Bienvenido al contador del uno al diez");
            //for(int x = 1; x <= 10; x++)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine("Fin del programa");


            //PROGRAMA CON "W H I L E"

            int x = 1;

            Console.WriteLine("Bienvenido al contador del uno al diez");
            while(x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            Console.WriteLine("Fin del contador");
        }
    }
}
