using System;

namespace ExtraSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, pri = 0, bp = 0, mp = 0;

            Console.WriteLine("Este programa identifica números primos, de hecho el mayor de ellos");
            for(int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingresa un número");
                n = int.Parse(Console.ReadLine());
                int c = 0;

                for(int y = 1; y <= n; y++)
                {
                    if((n % y) == 0)
                        c++;
                }

                if(c == 2)
                {
                    bp = 1;
                    if(pri == 0)
                    {
                        mp = n;
                        pri = 1;
                    }
                    else if(n > mp)
                        mp = n;
                    else{

                    }
                }
            }

            if(bp == 1)
                Console.WriteLine("El mayor primo es: " + mp);
            else{
                Console.WriteLine("No hay números primos");
            }
        }
    }
}
