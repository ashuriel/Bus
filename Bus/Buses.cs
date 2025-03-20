using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus
{
    public abstract class Buses
    {
        public int ruta { get; }
        public int precio { get; }
        

        public int asientos { get;}


        protected Buses(int Ruta, int Precio, int Asientos)
        {

            ruta = Ruta;
            precio = Precio;
            
            asientos = Asientos;
        }

        public abstract double CalcularPrecio();
        public abstract int CalcularAsientos();

        public override string ToString()
        {
            return $"";
        }


        



    }
    public class Autobus : Buses
    {
        public int pasajeros { get; }
        public Autobus(string rutas, int precio, int distancia, int pasajeros, int asientos) : base(rutas,distancia,precio,pasajeros,asientos) 
        {
        }
        public override double CalcularPrecio()
        {
            return precio * ruta;
        }
        public override int CalcularAsientos()
        {

            return asientos-pasajeros;

        }




    }

    public class Tipos : Buses
    {
        private static readonly double[] preciosPorTipos = { 50,100,150 };
        private readonly int tipo;

        public override double CalcularPrecio()
        {
            return preciosPorTipos[tipo-1] * ruta;
        }


    }
}
