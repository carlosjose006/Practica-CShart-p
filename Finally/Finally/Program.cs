using System;
using System.IO;

namespace Finally
{
    class Program
    {
        static void Main(string[] args)
        {
            String guardar;
            try
            {
                StreamReader ruta = new StreamReader(@"C:\Users\DELL\Desktop\Prueba.txt");
                guardar = ruta.ReadLine();

                while (guardar !=null)
                {
                    Console.WriteLine(guardar);
                    guardar = ruta.ReadLine();
                }
                ruta.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
