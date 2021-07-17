using System;

namespace IntroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo area = new Circulo();

            Console.WriteLine($"El area del circulo es: {area.calc(2.5)}"); 
        }
    }
    class Circulo
    {
        // Propiedades
        const double PI = 3.1416;

        //Metodo
        public double calc(double radio)
        {
            return PI * radio * radio;
        }
    }
}
