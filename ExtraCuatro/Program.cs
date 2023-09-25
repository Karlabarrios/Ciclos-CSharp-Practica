using System;

namespace ExtraCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, p;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());
            p = 1;
            m = n;

            for(int x = 0; x < 9; x++)
            {
                Console.WriteLine("Ingrese otro número");
                n = int.Parse(Console.ReadLine());

                if(n > m)
                {
                    m = n;
                    p = x + 2;
                }
            }

            Console.WriteLine("El número más grande es: " + m + " y la posición en donde fue encontrado es: " + p);

            /*ES MEJOR LA RESPUESTA DE LA ALTERNATIVA, ESTE PROGRAMA SI FUNCIONA PERO SERÍA
            MÁS PRECISO DECLARANDO LA PRIMERA VARIABLE MAYOR CUANDO X ESTA EN 0 Y POSTERIORMENTE PREGUNTAR 
            SI LOS DEMÁS NÚMERO QUE INGRESEN SON MÁS GRANDES, Y DETERMINAR QUE SU POSICIÓN ES P = X + 1.*/
        }
    }
}
