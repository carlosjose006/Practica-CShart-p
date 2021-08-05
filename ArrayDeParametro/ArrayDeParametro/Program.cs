using System;

namespace ArrayDeParametro
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] guardarArray = LeerDatos();

            foreach(int i in guardarArray)
            {
                Console.WriteLine(i);
            }



            

        }

        static int[] LeerDatos()
        {
            Console.WriteLine("Cuanto elementos quieres que se ingresen en el array?");
            int respuesta = Convert.ToInt32(Console.ReadLine());

            int[] datos = new int[respuesta];

            for (int i = 0; i < respuesta; i++)
            {
                Console.WriteLine($"Introduce los datos para la posicion {i}");
                datos[i] = Convert.ToInt32(Console.ReadLine());
            }

            return datos;
        }
    }
}
