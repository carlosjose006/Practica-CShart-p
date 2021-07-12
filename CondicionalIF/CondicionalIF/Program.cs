using System;

namespace CondicionalIF
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Cual es tu edad?");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad < 18) Console.WriteLine("Eres menor de edad");
            else Console.WriteLine("Eres mayor de edad");
        }
    }
}
