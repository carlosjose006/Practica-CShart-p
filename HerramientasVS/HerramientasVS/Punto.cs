using System;
using System.Collections.Generic;
using System.Text;

namespace HerramientasVS
{
    class Punto
    {
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            ContadorObjeto++;
        }
        public Punto()
        {
            this.x = 0;
            this.y = 0;
            ContadorObjeto++;
        }

        private int x, y;
        private static int ContadorObjeto=0;

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;

            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));
            return distanciaPuntos;
        }
        public static string ContadorDeObjeto()
        {
            return $"La Cantidad de objetos creado son: {ContadorObjeto}";
        }
    }
}
