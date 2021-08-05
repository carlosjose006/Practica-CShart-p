using System;

namespace EjmploArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sintaxis de un array

            //int[] arreglo1 = new int[4];

            //arreglo1[0] = 1;
            //arreglo1[1] = 2;
            //arreglo1[2] = 3;
            //arreglo1[3] = 4;

            //Console.WriteLine(arreglo1[0]);

            //int[] arreglo2;
            //arreglo2 = new int[] { 1, 2, 3, 4, 5 };

            //foreach (var item in arreglo1)
            //{
            //    Console.WriteLine(item);
            //}


            //for (int i = 0; i < arreglo2.Length; i++)
            //{
            //    Console.WriteLine($"La posiciones {i}:{arreglo2[i]}");
            //}

            // Array Implicito

            var num = new[] { 1, 2, 3, 4 };

            // Array de objeto
            Persona Empleado1 = new Persona("Carlos", 28);
            Persona Empleado2 = new Persona("Anyeli", 27);
            Persona Empleado3 = new Persona("Juan", 20);
            Persona Empleado4 = new Persona("Pedro", 40);
            Persona[] Empleados = new Persona[4];

            Empleados[0] = Empleado1;
            Empleados[1] = Empleado2;
            Empleados[2] = Empleado3;
            Empleados[3] = Empleado4;


            // Array de tipo o clases anonimas
            var Cantantes = new[]
            {
                new{nombre="Juan",edad=52},
                new{nombre="Juan",edad=52},
                new{nombre="Juan",edad=52}
            };

            foreach(var index in Cantantes)
            {
                Console.WriteLine(index);
            }

            for (int i = 0; i < Empleados.Length; i++)
            {
                Console.WriteLine(Empleados[i].GetInfo());
            }
        }
    }
    class Persona
    {
        public Persona(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        private String nombre;
        private int edad;

        public String GetInfo()
        {
            return "Mi nombre es: " + nombre + ", mi edad es: " + edad; ;
        }
    }
}
