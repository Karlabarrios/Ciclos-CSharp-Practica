using System;

namespace ExtraCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m = 0, p = 0;

            for(int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());

                if(x == 0)
                {
                    m = n;
                    p = 1;
                }
                else if(n < m)
                {
                    m = n;
                    p = x+1;
                }
                else{

                }
            }
            Console.WriteLine("El menor es: " + m + " y su posición es: " + p);
        }
    }
}
