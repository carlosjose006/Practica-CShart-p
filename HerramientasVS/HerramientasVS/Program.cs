using System;

namespace HerramientasVS
{
    class Program
    {
        static void Main(string[] args)
        {
            ejecutar();
        }
        static void ejecutar()
        {
            // El comentarios (TODO) se utiliza para enfatizar en que parte nos detuvimos en nuestro codigo
            // TODO:
            Punto destino = new Punto(25, 50);
            Punto origen = new Punto();
            Punto otroObjeto = new Punto();
            double distancia = origen.DistanciaHasta(destino);
            Console.WriteLine($"La distancia entre los dos puntos es: {Math.Round(distancia)}");
            Console.WriteLine(Punto.ContadorDeObjeto());

            // clases anonimas, son usadas conmunmente en base de datos.

            var VariableAnonima = new { Nombre = "Carlos", Edad = 28 };
        }
    }

    
}
