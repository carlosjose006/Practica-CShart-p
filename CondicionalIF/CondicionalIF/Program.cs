using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Alquiler de Vehiculos Morales");
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Cual es tu edad?");
            //int edad = Convert.ToInt32(Console.ReadLine());

            //if (edad < 18)  Console.WriteLine("No podemos alquilar los vehiculos a menores de edad"); 

            //else 
            //{
            //    Console.WriteLine("Tiene licencia de conducir: ");
            //    string carnet = Console.ReadLine(); ;

            //    int comparar = String.Compare("si", carnet);
            //    Console.WriteLine(comparar);

            //    if (carnet == "si") Console.WriteLine("Aplicas para adquirir uno de nuestros vehiculos");
            //    else Console.WriteLine("No podemos alquilar a personas sin licencia");
            //}

            //int edad;
            //Console.WriteLine( "Cual es tu edad?");
            //edad = Int32.Parse(Console.ReadLine());

            //if (edad < 18) Console.WriteLine("Eres un niño");
            //else if (edad >= 18 && edad <30) Console.WriteLine("Eres un joven");
            //else if (edad > 30 && edad < 50) Console.WriteLine("Eres un adulto mayor");
            //else Console.WriteLine("Eres un envejeciente");


            Console.WriteLine("------------Calcular el promedio de mis calificaciones----------------------");

            Console.WriteLine("Calificacion de la primera materia: ");
            int mat1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Calificacion de la primera materia: ");
            int mat2 = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Calificacion de la primera materia: ");
            int mat3 = Int32.Parse(Console.ReadLine());

            if (mat1 > 70 || mat1 > 70 || mat3 > 70) Console.WriteLine($"Le promedio de las nota es {(mat1 + mat2 + mat3) / 3}");
            else Console.WriteLine("Has reprobado");







        }
    }
}
