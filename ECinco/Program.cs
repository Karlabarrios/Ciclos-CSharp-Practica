using System;

namespace ECinco
{
    class Program
    {
        static void Main(string[] args)
        {
            // M I    R E S P U E S T A
            
            int n, mp = 0, mi = 0, bp = 0, bi = 0;

            for(int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());

                if((n % 2) == 0)
                {
                    if(bp == 0)
                    {
                        mp = n;
                        bp = 1;
                    }
                    else{
                        if(n > mp)
                            mp = n;
                    }
                }
                else{
                    if(bi == 0)
                    {
                        mi = n;
                        bi = 1;
                    }
                    else{
                        if(n < mi)
                            mi = n;
                    }
                }
            }
            Console.WriteLine("El mayor par es: " + mp + " El menor impar es: " + mi);
            
        }
    }
}
