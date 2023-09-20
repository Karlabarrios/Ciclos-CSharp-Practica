using System;

namespace ExtraTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0, n;

            for(int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número:");
                n = int.Parse(Console.ReadLine());

                if(n > 0)
                    c++;
            }

            Console.WriteLine("La cantidad de números positivos es: " + c);
        }
    }
}
