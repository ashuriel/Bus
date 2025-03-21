using System;
using System.Collections.Generic;

namespace Bus
{
    public abstract class Bus
    {
        public string Tipo { get; }
        public int Ruta { get; }
        public double PrecioBase { get; }
        public int AsientosTotales { get; }
        public int Pasajeros { get; protected set; }

        protected Bus(string tipo, int ruta, double precioBase, int asientosTotales)
        {
            Tipo = tipo;
            Ruta = ruta;
            PrecioBase = precioBase;
            AsientosTotales = asientosTotales;
            Pasajeros = 0;
        }

        public abstract void AgregarPasajeros(int cantidad);
        public abstract double CalcularVentas();
        public int AsientosDisponibles => AsientosTotales - Pasajeros;

        public override string ToString()
        {
            return $"{Tipo} {Pasajeros} Pasajeros Ventas {CalcularVentas():N0} quedan {AsientosDisponibles} asientos disponibles";
        }
    }

    public class BusPlatinum : Bus
    {
        public BusPlatinum(int ruta) : base("Auto Bus Plantinum", ruta, 1000, 22) { }

        public override void AgregarPasajeros(int cantidad)
        {
            if (cantidad <= AsientosDisponibles)
                Pasajeros += cantidad;
        }

        public override double CalcularVentas()
        {
            return Pasajeros * PrecioBase * 1.2; // 20% de recargo
        }
    }

    public class BusGold : Bus
    {
        public BusGold(int ruta) : base("Auto Bus Gold", ruta, 1000, 15) { }

        public override void AgregarPasajeros(int cantidad)
        {
            if (cantidad <= AsientosDisponibles)
                Pasajeros += cantidad;
        }

        public override double CalcularVentas()
        {
            return Pasajeros * PrecioBase * 1.1; // 10% de recargo
        }
    }

    public class CentralBuses
    {
        private readonly List<Bus> _buses = new List<Bus>();

        public void AgregarBus(Bus bus)
        {
            _buses.Add(bus);
        }

        public void MostrarReporte()
        {
            Console.WriteLine("\n--- Reporte de Buses ---");
            foreach (var bus in _buses)
            {
                Console.WriteLine(bus);
            }
        }
    }

    
}
