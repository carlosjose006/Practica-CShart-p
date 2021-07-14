using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de mes");

            int mes = Convert.ToInt32(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("El mes seleccionado es Enero");
                    break;
                case 2:
                    Console.WriteLine("El mes seleccionado es Febrero");
                    break;
                case 3:
                    Console.WriteLine("El mes seleccionado es Marzo");
                    break;
                case 4:
                    Console.WriteLine("El mes seleccionado es Abril");
                    break;
                case 5:
                    Console.WriteLine("El mes seleccionado es Mayo");
                    break;
                case 6:
                    Console.WriteLine("El mes seleccionado es Junio");
                    break;
                case 7:
                    Console.WriteLine("El mes seleccionado es Julio");
                    break;
                case 8:
                    Console.WriteLine("El mes seleccionado es Agosto");
                    break;
                case 9:
                    Console.WriteLine("El mes seleccionado es Septiembre");
                    break;
                case 10:
                    Console.WriteLine("El mes seleccionado es Octubre");
                    break;
                case 11:
                    Console.WriteLine("El mes seleccionado es Noviembre");
                    break;
                case 12:
                    Console.WriteLine("El mes seleccionado es Diciembre");
                    break;

            }
        }
    }
}
