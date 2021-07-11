using System;

namespace MetodosConParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            Suma(2.5, 5.5);

        }

        //Ambito y sobrecargar de metodos
        static int Suma(int num1, int num2) => num1 + num2;

        static int Suma(double num1, double num2)
        {
            double result = num1 + num2;

            return (int) result;
                
        }

        

        
    }

    
}
