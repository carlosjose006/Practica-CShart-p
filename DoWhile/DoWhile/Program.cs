using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);


            int numeroUsuario;

            int contador = 0;


            do
            {
                contador++;
                Console.WriteLine("Ingrese el numero");
                try {
                    numeroUsuario = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al digitar el numero, se tomo como un 0");
                    Console.WriteLine(ex.Message);
                    numeroUsuario = 0;
                }
                

                if (numeroUsuario > numeroAleatorio)
                {
                    Console.WriteLine("El numero ingresado es mayor");
                }
                else if (numeroUsuario < numeroAleatorio)
                {
                    Console.WriteLine("El numero ingresado es menor");
                }
                

            } while (numeroUsuario != numeroAleatorio);
            Console.WriteLine("Felicidades, lo lograste");
            Console.WriteLine($"Lo has logrado a los {contador} intentos");
        }
    }
}
