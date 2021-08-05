using System;

namespace IntroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Circulo area = new Circulo();

            //Console.WriteLine($"El area del circulo es: {area.Calc(2.5)}");


            ConversorEuroDollar valor = new ConversorEuroDollar();

            //valor.cambiaValorEuro(-2);


            Console.WriteLine($"La conversion es equivalente a {valor.Convierte(50)} dollar");


        }
    }
    class Circulo
    {
        // Propiedades
        // private se utiliza para encapsular el codigo
       private  const double PI = 3.1416;

        //Metodo
        public double Calc(double radio)
        {
            return PI * radio * radio;
        }
    }
    class ConversorEuroDollar
    {

        private double euro = 1.18;    

        public double Convierte(double cantidad)
        {
            return cantidad * euro;
        }

        public void cambiaValorEuro(double nuevoValor)
        {
            if (nuevoValor < 0) euro = euro;
            else euro = nuevoValor;
        }


    
    
    }
}
