using System;

namespace bucleWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroAleatorio = numero.Next(0, 100);

            Console.WriteLine("Ingrese el numero");
            int numeroUsuario = Convert.ToInt32(Console.ReadLine());

            int contador = 1;

            while (numeroUsuario != numeroAleatorio)
            {

                if (numeroUsuario > numeroAleatorio) { Console.WriteLine("El numero ingresado es mayor");
                  Console.WriteLine("Intententalo de nuevo con otro numero");
                  numeroUsuario = Convert.ToInt32(Console.ReadLine());
                }
                else if (numeroUsuario < numeroAleatorio) { Console.WriteLine("El numero ingresado es menor");

                    Console.WriteLine("Intententalo de nuevo con otro numero");
                    numeroUsuario =Convert.ToInt32(Console.ReadLine());

                }
                contador++;
                
            }
            Console.WriteLine("Felicidades, lo lograste");
            Console.WriteLine($"Lo has logrado a los {contador} intentos");
        }
    }
}
