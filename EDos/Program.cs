using System;

namespace EDos
{
    class Program
    {
        static void Main(string[] args)
        {
            // PROGRAMA RESUELTO CON " F O R "
            
            // int n, m;

            // Console.WriteLine("Ingrese un número");
            // n = int.Parse(Console.ReadLine());
            // m = n;

            // for(int x = 0; x < 9; x++)
            // {
            //     Console.WriteLine("Ingrese otro número x fa");
            //     n = int.Parse(Console.ReadLine());

            //     if(n > m)
            //         m = n;
            // }

            // Console.WriteLine("El mayor de todos los números es: " + m);



            // PROGRAMA RESUELTO CON " F O R " ALTERNATIVA***

            int n, m = 0;

            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());

                if(x == 0)
                    m = n;

                else if(n > m)
                    m = n;
            
            }

            Console.WriteLine("El número más grande es: " + m);
        }
    }
}
