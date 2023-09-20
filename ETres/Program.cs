using System;

namespace ETres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola");
            Console.WriteLine("Este programa te ayudará a calcular el promedio de edad de 20 personas mayores a 18");
            
            int a = 0, c = 0, p, e;

            for(int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingresa una edad");
                e = int.Parse(Console.ReadLine());

                if(e > 18)
                {
                    c++;
                    a += e;
                }
                else
                {

                }
            }

            p = a / c;
            Console.WriteLine("El promedio de mayores a 18 es de: " + p);
        }
    }
}
