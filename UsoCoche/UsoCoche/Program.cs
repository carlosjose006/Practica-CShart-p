using System;

namespace UsoCoche
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche();

            Coche coche2 = new Coche();

            Coche coche3 = new Coche(2400, 0.900);

            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());
            Console.WriteLine(coche3.getInfoCoche());

            coche1.SetExtra(true, "Cuero");
            Console.WriteLine(coche1.getExtra());



        }
    }

    partial class Coche {

        public Coche()
        {
            ruedas = 4;
            largo = 2300.5;
            ancho = 0.800;
            tapiceria = "Tela";
        }

        public Coche(double largoCoche, double anchoCoche)
        {
            ruedas = 4;
            largo = largoCoche;
            ancho = anchoCoche;
            tapiceria = "Tela";
        }

    }
    partial class Coche
    { 
        private int ruedas;
        private double largo;
        private double ancho;

        private bool climatizador;
        private String tapiceria;


        // Los metodos Getter se utilizan para acceder o ver las propiedades de un objeto
        public String getInfoCoche() {

            return $"Este coche tiene {ruedas} ruedas, un acho de {ancho} y un largo de {largo}";
        
        }

        public void SetExtra(bool climatizador, String tapiceria)
        {

            
            this.climatizador = climatizador;
            this.tapiceria = tapiceria;
        }
        
        public String getExtra()
        {
            return $"Climatizador: {climatizador}, Tapiceria: {tapiceria}";
        }

    }
}
