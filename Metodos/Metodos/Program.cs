using System;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Practicando lod metodos en C#");

            // Medodos que devuelven un valor
            int sumando()
            {
                int num1 = 5;
                int num2 = 8;

                int resultado = num1 + num2;

                return resultado;
            }

            Console.WriteLine(sumando());

            // Metodos que no ddevuelven un valor 

            void resta()
            {
                int num1 = 15;
                int num2 = 8;

                int resultado = num1 - num2;

                Console.WriteLine("----------------------------------------");

                Console.WriteLine($"El resultado de la resta es: {resultado}");

            }

            resta();

            // Metodos con parametros 

            int num1, num2;

            Console.WriteLine("Introduce el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero");
            num2 = Int32.Parse(Console.ReadLine());

            void multiplicacion (int num1, int num2)
            {
                int resultado = num1 * num2;

                Console.WriteLine($"El resultado de la multiplicacion: {resultado} ");

            }

            multiplicacion(num1, num2);

            Console.ReadKey();
          
        }
    }
}
