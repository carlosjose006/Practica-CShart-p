using System;

namespace Exepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes;
            Console.WriteLine("Introduce el numero de mes: ");
            mes = Convert.ToInt32(Console.ReadLine());

            try {

                Console.WriteLine(Mes(mes));

            }catch(Exception ex)
            {
                Console.WriteLine("Favor colocar un numero del 1 al 12");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Codigo que se quiera mostrar sin importar los que pase");
            }
            


            Console.WriteLine("Continua el programa ");
        }

        public static string Mes(int num)
        {

            switch (num)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                     throw new IndexOutOfRangeException();



            }



        }
    }

}