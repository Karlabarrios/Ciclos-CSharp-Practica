using System;

namespace ECuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROGRAMA RESUELTO CON " F O R "

            // int n, c = 0;

            // Console.WriteLine("Ingrese un número");
            // n = int.Parse(Console.ReadLine());

            // for(int x = 1; x <= n; x++)
            // {
            //     if((n % x) == 0)
            //         c++;
            // }

            // if(c == 2)
            //     Console.WriteLine("Ingresaste un número primo");
            // else
            //     Console.WriteLine("El número que ingresaste no es primo");

            // Console.WriteLine("Fin del programa");



            // PROGRAMA RESUELTO CON " W H I L E"

            int n, c = 0, x = 1;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            while(x <= n)
            {
                if((n % x) == 0)
                    c++;

                x++;
            }

            if(c == 2)
                Console.WriteLine("Es un número primo");
            else
                Console.WriteLine("No es un número primo");
        }
    }
}
