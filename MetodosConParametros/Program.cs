using System;

namespace MetodosConParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1, num2;
            Console.WriteLine("Digite el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"El resultado de la suma es: {suma(num1, num2)}");
        }

        //static int suma(int num1, int num2) => num1 + num2;

        static int suma(int num1, int num2)
        {
            int result = num1 + num2;

            return result;
                
        }
    }

    
}
